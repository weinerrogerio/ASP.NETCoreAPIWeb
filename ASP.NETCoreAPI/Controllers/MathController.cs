using ASP.NETCoreAPI.Services;
using ASP.NETCoreAPI.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ASP.NETCoreAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        private readonly IMathService _mathService;

        public MathController(IMathService mathService)
        {
            _mathService = mathService;
        }

        // Rotas ultra limpas chamando o serviço
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber) => Execute(firstNumber, secondNumber, _mathService.Sum);

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult Med(string firstNumber, string secondNumber) => Execute(firstNumber, secondNumber, _mathService.Mean);

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber) => Execute(firstNumber, secondNumber, _mathService.Sub);

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult Mult(string firstNumber, string secondNumber) => Execute(firstNumber, secondNumber, _mathService.Mult);

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            try
            {
                return Execute(firstNumber, secondNumber, _mathService.Div);
            }
            catch ( DivideByZeroException ex )
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number) {
            //Execute(number, "0", (a, b) => ( decimal ) _mathService.Sqrt(a));
            try
            {
                return Execute(number, "0", (a, b) => _mathService.Sqrt(a));
            }
            catch ( ArgumentOutOfRangeException ex )
            {
                return BadRequest(new { error = ex.Message });
            }

        }


        // O "Execute" agora é o encarregado do fluxo HTTP
        private IActionResult Execute(string firstNumber, string secondNumber, Func<decimal, decimal, decimal> operation)
        {
            // 1. Validação usando seu NumberHelper estático
            if ( !NumberHelper.IsNumeric(firstNumber) || !NumberHelper.IsNumeric(secondNumber) )
                return BadRequest("Invalid Input");

            // 2. Conversão e Execução da lógica do Serviço
            var result = operation(NumberHelper.ConvertToDecimal(firstNumber), NumberHelper.ConvertToDecimal(secondNumber));

            // 3. Resposta formatada
            return Ok(result.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
