using ASP.NETCoreAPI.Utils;

namespace ASP.NETCoreAPI.Services
{
    public interface IMathService
    {
        decimal Sum(decimal a, decimal b);
        decimal Sub(decimal a, decimal b);
        decimal Mult(decimal a, decimal b);
        decimal Div(decimal a, decimal b);
        decimal Mean(decimal a, decimal b);
        decimal Sqrt(decimal a);
    }

    public class MathService : IMathService
    {
        public decimal Sum(decimal a, decimal b) => a + b;
        public decimal Sub(decimal a, decimal b) => a - b;
        public decimal Mult(decimal a, decimal b) => a * b;
        public decimal Div(decimal a, decimal b)
        {
            if ( b == 0 )
            {
                string msg = a == 0 ? "Forma indeterminada (0/0)." : "Não é possível dividir por zero";
                throw new DivideByZeroException();
            }
            return a / b;
        }
        public decimal Mean(decimal a, decimal b) => ( a + b ) / 2; 
        public decimal Sqrt(decimal a)
        {
            if ( a < 0 ) throw new ArgumentOutOfRangeException("Não é possivel calcular raiz quadrada de um número negativo.");
            return Convert.ToDecimal(Math.Sqrt(( double )  a ));
        }
    }
}