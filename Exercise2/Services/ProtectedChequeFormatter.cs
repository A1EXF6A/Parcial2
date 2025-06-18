using ChequeProtegido.Interfaces;
using System.Text;

namespace ChequeProtegido.Services
{
    public class ProtectedChequeFormatter : IChequeFormatter
    {
        private const int ESPACIOS_CHEQUE = 8;

        public string Formatear(double monto)
        {
            string montoTexto = monto.ToString("F2").Replace('.', ',');
            int totalCaracteres = montoTexto.Length;
            int asteriscosNecesarios = ESPACIOS_CHEQUE - totalCaracteres;

            StringBuilder resultado = new StringBuilder();

            for (int i = 0; i < asteriscosNecesarios; i++)
            {
                resultado.Append("*");
            }

            resultado.Append(montoTexto);
            return resultado.ToString();
        }
    }
}