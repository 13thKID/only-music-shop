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
		public async Task<Result<List<Guitar>>> Get()
		{
			var response = await _mediator.Send(new GetAllGuitarsQuery());
			return response;
		}

		// GET api/<GuitarsController>/5
		[HttpGet("{id}")]
		public async Task<Result<Guitar>> Get(int id)
		{
			var response = await _mediator.Send(new GetGuitarByIdQuery(id));
			return response;
		}

		// POST api/<GuitarsController>
		[HttpPost]
		public async Task<Result> Post([FromBody] CreateGuitarRequest payload)
		{
			var response = await _mediator.Send(new CreateGuitarCommand(payload));

			return response;
		}

		// PUT api/<GuitarsController>/5
		[HttpPut("{id}")]
		public Guitar Put(int id, [FromBody] CreateGuitarRequest attr)
		{
			return _guitarRepository.UpdateGuitar(id, attr);
		}

		// DELETE api/<GuitarsController>/5
		[HttpDelete("{id}")]
		public async Task<Result<Guitar>> Delete(int id)
		{
			var response = await _mediator.Send(new DeleteGuitarCommand(id));
			return response;
		}
	}
}
