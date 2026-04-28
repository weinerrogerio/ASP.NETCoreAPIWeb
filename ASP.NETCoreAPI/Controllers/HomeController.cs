using Microsoft.AspNetCore.Mvc;

namespace ASP.NETCoreAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public string Get() { return "ola"; }

        [HttpPost]
        public string Post() { return "Teste de Post"; }

    }
}
