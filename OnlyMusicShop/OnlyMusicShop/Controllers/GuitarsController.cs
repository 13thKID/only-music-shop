using Microsoft.AspNetCore.Mvc;
using OnlyMusicShop.Application.Repositories;
using OnlyMusicShop.Domain.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        //// GET api/<GuitarsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<GuitarsController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<GuitarsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<GuitarsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
