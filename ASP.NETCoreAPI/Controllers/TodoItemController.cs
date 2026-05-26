using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Models.Dto;
using ASP.NETCoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
                
        private readonly ITodoItemServices _todoItemServices;
        private readonly ILogger<TodoItemController> _logger;

        public TodoItemController(ITodoItemServices todoItemServices, ILogger<TodoItemController> logger)
        {
            _todoItemServices = todoItemServices;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(
            [FromQuery] string? title, 
            [FromQuery] bool? isDone, 
            [FromQuery] int page = 1, 
            [FromQuery] int size = 10)
        {
            //Console.WriteLine($"Enviando todos os itens ${title} e ${isDone}");
            var item = _todoItemServices.FindAll(title, isDone, page, size);
            if ( item == null || item.Count == 0 ) return NotFound("Tasks not found");
            return Ok(item);
        }

        [HttpGet("{id}")] // api/task/1
        public IActionResult Get(int id)
        {
            var item = _todoItemServices.FindById(id);
            if (item == null) return NotFound("Task not found");
            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post([FromBody] TodoItem todoItem)
        {
            var item = _todoItemServices.Create(todoItem);
            if (item == null) return BadRequest("Item not created: Invalid or incomplete data");
            return Ok(item);
        }

        [HttpPatch]
        public IActionResult Patch([FromBody] UpdateTodoItemDto todoItem)
        {
            var item = _todoItemServices.Update(todoItem);
            if (item == null) return BadRequest("Item not updated: Invalid or incomplete data");
            return Ok(item);
        }

        [HttpDelete("{id}")] // todoitem/1 ...
        public IActionResult Delete(int id)
        {
            var item = _todoItemServices.Delete(id);
            if ( item == false ) return BadRequest("Item not deleted: Invalid or incomplete data");
            return Ok(item);
        }
    }
}
