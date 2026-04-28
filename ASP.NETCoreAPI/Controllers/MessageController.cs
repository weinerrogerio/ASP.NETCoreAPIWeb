using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {


        private readonly IMessageServices _service;
        public MessageController(IMessageServices service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.FindAll());
        }
        [HttpGet("{id}")] // api/message/1
        public IActionResult Get(int id)
        {
            return Ok(_service.FindById(id));
        }
        [HttpPost]
        public IActionResult Post([FromBody] Message message)
        {
            var createdMessage = _service.Create(message);

            if ( createdMessage == null )
            {
                return BadRequest("Recado inválido! Verifique o autor e o limite de 150 caracteres.");
            }

            return Ok(createdMessage);
        }
        

        [HttpPut]
        public IActionResult Put([FromBody] Message message)
        {
            var createdMessage = _service.Update(message);

            if ( createdMessage == null )
            {
                return BadRequest("Recado inválido! Verifique o autor e o limite de 150 caracteres.");
            }
            return Ok(message);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            return Ok(_service.Delete(id));
        }



    }
}
