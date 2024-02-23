using FluentValidation;
using MediatR;
using OnlyMusicShop.Domain.Shared;

namespace OnlyMusicShop.Application.Behaviours
{
	public sealed class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
	where TRequest : IRequest<TResponse>
	where TResponse : Result
	{
		private readonly IEnumerable<IValidator<TRequest>> _validators;

		public ValidationBehavior(IEnumerable<IValidator<TRequest>> validators)
		{
			_validators = validators;
		}

		public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
		{
			// Validate request
			// If any errors, return validation result
			// Otherwise, return next()

			if (!_validators.Any())
			{
				return await next();
			}

			Error[] errors = _validators
				.Select(validator => validator.Validate(request))
				.SelectMany(validationResult => validationResult.Errors)
				.Where(validationFailure => validationFailure is not null)
				.Select(failure => new Error( // Projecting errors to Error instances
					failure.PropertyName,
					failure.ErrorMessage))
				.Distinct()
				.ToArray();

			if (errors.Any())
			{
				// Return Validation Result
				return CreateValidationResult<TResponse>(errors);
			}

			return await next();
		}

		public static TResult CreateValidationResult<TResult>(Error[] errors)
			where TResult : Result
		{
			if (typeof(TResult) == typeof(Result))
			{
				return (ValidationResult.WithErrors(errors) as TResult)!;
			}

			object validationResult = typeof(ValidationResult<>)
				.GetGenericTypeDefinition()
				.MakeGenericType(typeof(TResult).GenericTypeArguments[0])
				.GetMethod(nameof(ValidationResult.WithErrors))!
				.Invoke(null, new object?[] { errors })!;

			return (TResult)validationResult;
		}
	}
}