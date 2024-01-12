using Microsoft.AspNetCore.Mvc;
using OnlyMusicShop.Application.Repositories;
using OnlyMusicShop.Domain.Entities;


namespace OnlyMusicShop.Controllers
{

	[Route("api/[controller]")]
    [ApiController]
    public class GuitarsController : ControllerBase
    {
        private readonly IGuitarRepository _guitarRepository;

        public GuitarsController(IGuitarRepository guitarRepository)
        {
            _guitarRepository = guitarRepository;
        }
        // GET: api/<GuitarsController>
        [HttpGet]
        public IEnumerable<Guitar> Get()
        {
            return _guitarRepository.GetGuitars();
        }

        // GET api/<GuitarsController>/5
        [HttpGet("{id}")]
        public Guitar Get(int id)
        {
            return _guitarRepository.GetGuitar(id);
        }

        // POST api/<GuitarsController>
        [HttpPost]
        public Guitar Post([FromBody] GuitarAttributes payload)
        {
            return _guitarRepository.CreateGuitar(payload);
        }

        // PUT api/<GuitarsController>/5
        [HttpPut("{id}")]
        public Guitar Put(int id, [FromBody] GuitarAttributes attr)
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
