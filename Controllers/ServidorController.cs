using System.Collections.Generic;
using MCTransparencia.Models;
using MCTransparencia.Models.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCTransparencia.Controllers
{
    [Route("api/servidor")]
    [ApiController]
    public class ServidorController : ControllerBase
    {
        private readonly IDataRepository<Servidor> dataRepository;
        public ServidorController(IDataRepository<Servidor> dataRepository)
        {
            this.dataRepository = dataRepository;
        }
        // GET: api/<ServidorController>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Servidor> servidores = dataRepository.GetAll();
            return Ok(servidores);
        }

        // GET api/<ServidorController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(dataRepository.Get(id));
        }

        // POST api/<ServidorController>
        [HttpPost]
        public IActionResult Post([FromBody] Servidor value)
        {
            if (value == null)
                return BadRequest("Servidor is null");

            dataRepository.Add(value);
            return CreatedAtRoute("Get", new { id = value.Id }, value);
        }

        // PUT api/<ServidorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Servidor value)
        {
            if (value == null)
                return BadRequest("Servidor is null");
            var toUpdate = dataRepository.Get(id);

            if (toUpdate == null)
                return NotFound("Servidor not found");

            dataRepository.Update(toUpdate, value);
            return NoContent();
        }

        // DELETE api/<ServidorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var toDelete = dataRepository.Get(id);

            if (toDelete == null)
                return NotFound("Servidor not found");

            dataRepository.Delete(toDelete);
            return NoContent();
        }
    }
}
