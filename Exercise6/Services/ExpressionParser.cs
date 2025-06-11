using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise6.Interfaces;

namespace Exercise6.Services
{
    public class ExpressionParser : IParser
    {
        public double Evaluate(string expression)
        {
            try
            {
                var result = new DataTable().Compute(expression, null);
                return Convert.ToDouble(result);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Expresión inválida o error durante la evaluación.", ex);
            }
        }
    }
}
 