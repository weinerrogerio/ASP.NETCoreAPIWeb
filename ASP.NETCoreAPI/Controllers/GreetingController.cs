using ASP.NETCoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {

        // usar "_algo" para indicar que é uma variável privada atual, ou seja pertence a classe atual, é a mesma coisa que estcrever "this.algo"
        private static long _counter = 0;
        private static readonly string _template = "Hello, {0}";

        [HttpGet]
        public Greeting Get([FromQuery] string name = "World")
        {
            var id = Interlocked.Increment(ref _counter);
            var content = string.Format(_template, name);

            return new Greeting(id, content);
        }

        


    }
}
