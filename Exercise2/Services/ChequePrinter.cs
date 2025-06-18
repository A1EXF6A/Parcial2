using ChequeProtegido.Interfaces;
using System;

namespace ChequeProtegido.Services
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
            string resultado = _formatter.Formatear(monto);
            Console.WriteLine($"Monto protegido: {resultado}");
            Console.WriteLine("Posiciones     : 12345678");
        }
    }
}