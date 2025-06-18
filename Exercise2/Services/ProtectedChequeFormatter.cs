using Exercise2.Interfaces;
using System.Globalization;

namespace Exercise2.Services
{
    public class ProtectedChequeFormatter : IChequeFormatter
    {
        private const int ESPACIOS = 8;

        public string FormatearMonto(double monto)
        {
            string montoFormateado = monto.ToString("N2", new CultureInfo("es-ES"));
            return montoFormateado.PadLeft(ESPACIOS, '*');
        }
    }
}