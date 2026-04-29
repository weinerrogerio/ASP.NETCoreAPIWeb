using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        private readonly IPersonServices _personServices;
        private readonly ILogger<PersonController> _logger;

        public PersonController(IPersonServices personServices, ILogger<PersonController> logger) {
            _personServices = personServices;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(
            [FromQuery] int page = 1,
            [FromQuery] int size = 10)
        {
            _logger.LogInformation("Buscando todas as pessoas");
            var persons = _personServices.FindAll(page, size);
            if ( persons == null ) {
                _logger.LogWarning("Nenhuma pessoa encontrada");
                return NotFound();
             };
            return Ok(persons);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            _logger.LogInformation("Buscando uma pessoa com ID: {id}", id);
            var person = _personServices.FindById(id);
            if ( person == null ) {
                _logger.LogWarning("Nenhuma pessoa encontrada com ID: {id}", id);
                return NotFound();
            } 
            return Ok(person);
        }

        //criar
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            _logger.LogInformation("Criando uma nova pessoa: {fistName}", person.FirstName);
            var personCreated = _personServices.Create(person);
            if ( personCreated == null ) {
                _logger.LogWarning("Erro ao criar a pessoa, dados inválidos ou incompletos");
                return BadRequest();
            } 
            return Ok(personCreated);
        }

        //atualizar
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            _logger.LogInformation("Atualizando a pessoa com ID: {id}", person.Id);
            var personUpdated = _personServices.Update(person);
            if ( person == null ) {
                _logger.LogError("Erro ao atualizar a pessoa com id: {id}", person.Id);
                return BadRequest(); 
            }
            _logger.LogDebug("Pessoa atualizada com sucesso: ID: {id}, FirstName: {firstName}", person.Id, person.FirstName);
            return Ok(personUpdated);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _logger.LogInformation("Deletando a pessoa com ID: {id}", id);
            _personServices.Delete(id);
            _logger.LogDebug("Pessoa deletada com sucesso: ID: {id}", id);
            return NoContent();
        }
    }
}
