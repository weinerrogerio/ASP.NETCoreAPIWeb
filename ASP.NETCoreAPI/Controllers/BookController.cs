using ASP.NETCoreAPI.Models;
using ASP.NETCoreAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly IBookServices _bookService;

        public BookController(IBookServices bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] int page = 1, [FromQuery] int size = 10) {
            var book = _bookService.FindAll(page, size);
            if (book == null) return NotFound("Books not found");
            return Ok(book);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _bookService.FindById(id);
            if (book == null) return NotFound("Book not found");
            return Ok(book);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Books book)
        {
            var createdBook = _bookService.Create(book);
            if (createdBook == null) return BadRequest("Book not created: Invalid or incomplete data");
            return Ok(createdBook);
        }


        [HttpPatch]
        public IActionResult Patch([FromBody] UpdateBooksDto book)
        {
            var updatedBook = _bookService.Update(book);
            if (updatedBook == null) return BadRequest("Book not updated: Invalid or incomplete data");
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id) {
            var deletedBook = _bookService.Delete(id);
            if (deletedBook == false) return BadRequest("Book not deleted: Invalid or incomplete data");
            return Ok(deletedBook);
        }
    }
}
