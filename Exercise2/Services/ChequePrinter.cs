using Exercise2.Interfaces;
using System;

namespace Exercise2.Services
{
    public class ChequePrinter
    {
        private readonly IChequeFormatter _formatter;

        public ChequePrinter(IChequeFormatter formatter)
        {
            _formatter = formatter;
        }

        public void ImprimirMonto(double monto)
        {
            string protegido = _formatter.FormatearMonto(monto);
            Console.WriteLine($"Monto protegido: {protegido}");
            Console.WriteLine("Posiciones     : 12345678");
        }
    }
}