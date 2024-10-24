using CitasMedicaApp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CitasMedicas.Reservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaController : ControllerBase
    {
        public class citaController(IBaseRepository baseRepository)
        { 
            _baseRepository = baseRepository;
        }
        // GET: api/<CitaController>
        [HttpGet("Get citas")]
        public async Task<IActionResult> Get()
        {
            var result = await _baseRepository.GetAll();
            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }

        // GET api/<CitaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CitaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CitaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CitaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
