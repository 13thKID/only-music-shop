using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlyMusicShop.Application.Queries;
using OnlyMusicShop.Application.Requests;
using OnlyMusicShop.Domain.Entities;
using OnlyMusicShop.Application.Commands;
using OnlyMusicShop.Application.Interfaces;
using OnlyMusicShop.Domain.Models;
using OnlyMusicShop.Domain.Shared;


namespace OnlyMusicShop.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class GuitarsController : BaseController
	{
		private readonly IGuitarRepository _guitarRepository;
		private readonly IMediator _mediator;

		public GuitarsController(IGuitarRepository guitarRepository, IMediator mediator)
		{
			_guitarRepository = guitarRepository;
			_mediator = mediator;
		}
		//GET: api/<GuitarsController>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var result = await _mediator.Send(new GetAllGuitarsQuery());

			if (result.IsFailure)
			{
				return HandleFailure(result);
			}

			return Ok(result);
		}

		// GET api/<GuitarsController>/5
		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var result = await _mediator.Send(new GetGuitarByIdQuery(id));

			if (result.IsFailure)
			{
				return HandleFailure(result);
			}

			return Ok(result);
		}

		// POST api/<GuitarsController>
		[HttpPost]
		public async Task<IActionResult> Post([FromBody] CreateGuitarRequest payload)
		{
			var result = await _mediator.Send(new CreateGuitarCommand(payload));

			if (result.IsFailure)
			{
				return HandleFailure(result);
			}

			return CreatedAtAction(nameof(CreateGuitarCommand), result.Value);
		}

		// PUT api/<GuitarsController>/5
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, [FromBody] UpdateGuitarRequest attr)
		{
			var result = await _mediator.Send(new UpdateGuitarCommand(id, attr));

			if (result.IsFailure)
			{
				return HandleFailure(result);
			}

			return UpdatedAtAction(nameof(CreateGuitarCommand), result.Value);
		}

		// DELETE api/<GuitarsController>/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			var result = await _mediator.Send(new DeleteGuitarCommand(id));

			if (result.IsFailure)
			{
				return HandleFailure(result);
			}

			return Ok(result);
		}
	}
}
