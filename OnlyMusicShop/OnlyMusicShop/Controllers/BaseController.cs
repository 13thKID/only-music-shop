using System.Net;
using OnlyMusicShop.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using OnlyMusicShop.Domain.Shared;
using Microsoft.AspNetCore.Mvc.Core.Infrastructure;

namespace OnlyMusicShop.Controllers;

public class BaseController: ControllerBase
{
    [NonAction]
    public OkObjectResult OkOrError(object? value)
    {
        var result = new OkObjectResult(value);
        if (value is IResponseResult response)
        {
            result.StatusCode = GetStatusCode(response.ErrorType);
            return result;
        }

        return base.Ok(value);
    }

    private int? GetStatusCode(ErrorType responseErrorType)
    {
        var result = 0;
        switch (responseErrorType)
        {
            case ErrorType.NotFound:
                result = (int)HttpStatusCode.NotFound;
                break;
            case ErrorType.ValidationError:
                result = (int)HttpStatusCode.BadRequest;
                break;
            case ErrorType.None:
                break;
        }

        return result;
    }

    protected IActionResult HandleFailure(Result result) =>
        result switch
        {
            { IsSuccess: true } => throw new InvalidOperationException(),
			IValidationResult validationResult =>
				BadRequest(
                    CreateProblemDetails(
                        "Validation Error", 
                        StatusCodes.Status400BadRequest, 
                        result.Error, validationResult.Errors
                        )),
            _ => BadRequest(
					CreateProblemDetails(
						"Validation Error",
						StatusCodes.Status400BadRequest,
						result.Error
						))
		};

    private static ProblemDetails CreateProblemDetails(
        string title,
        int status,
        Error error,
        Error[]? errors = null) =>
        new()
        {
            Title = title,
            Type = error.Code,
            Detail = error.Message,
            Status = status,
            Extensions = { { nameof(errors), errors } }
        };

	[NonAction]
	public virtual UpdatedAtActionResult UpdatedAtAction(string actionName, object value)
	=> UpdatedAtAction(actionName, routeValues: null, value: value);

	[NonAction]
	public virtual UpdatedAtActionResult UpdatedAtAction(string actionName, object routeValues, object value)
			=> UpdatedAtAction(actionName, controllerName: null, routeValues: routeValues, value: value);

	[NonAction]
	public virtual UpdatedAtActionResult UpdatedAtAction(
					string actionName,
					string controllerName,
					object routeValues,
					object value)
					=> new UpdatedAtActionResult(actionName, controllerName, routeValues, value);
}