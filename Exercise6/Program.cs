using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise6.Interfaces;
using Exercise6.Services;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una expresión numérica:");
            string input = Console.ReadLine();

            IValidator validator = new ExpressionValidator();
            IParser parser = new ExpressionParser();

            try
            {
                if (!validator.IsValid(input))
                {
                    Console.WriteLine("Expresión no válida. Contiene caracteres inválidos o tiene un formato incorrecto.");
                    return;
                }

                double result = parser.Evaluate(input);
                Console.WriteLine($"Resultado: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al evaluar la expresión: {ex.Message}");
            }
        }
    }
}
