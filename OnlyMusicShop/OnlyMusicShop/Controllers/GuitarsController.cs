using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlyMusicShop.Infrastructue.Queries;
using OnlyMusicShop.Infrastructue.Repositories;
using OnlyMusicShop.Infrastructue.Repositories.Requests;
using OnlyMusicShop.Domain.Entities;


namespace OnlyMusicShop.Controllers
{

	[Route("api/[controller]")]
    [ApiController]
    public class GuitarsController : ControllerBase
    {
        private readonly IGuitarRepository _guitarRepository;
        private readonly IMediator _mediator;

        public GuitarsController(IGuitarRepository guitarRepository, IMediator mediator)
        {
            _guitarRepository = guitarRepository;
			_mediator = mediator;
        }
        // GET: api/<GuitarsController>
        [HttpGet]
        public async Task<IEnumerable<Guitar>> Get()
        {
            var response = await _mediator.Send(new GetAllGuitarsQuery());
            return response;
        }

        // GET api/<GuitarsController>/5
        [HttpGet("{id}")]
        public Guitar Get(int id)
        {
            return _guitarRepository.GetGuitar(id);
        }

        // POST api/<GuitarsController>
        [HttpPost]
        public Guitar Post([FromBody] CreateGuitarRequest payload)
        {
            return _guitarRepository.CreateGuitar(payload);
        }

        // PUT api/<GuitarsController>/5
        [HttpPut("{id}")]
        public Guitar Put(int id, [FromBody] CreateGuitarRequest attr)
        {
            return _guitarRepository.UpdateGuitar(id, attr);
        }

        // DELETE api/<GuitarsController>/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return _guitarRepository.RemoveGuitar(id);
        }
    }
}
