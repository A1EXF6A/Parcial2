using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise2.Interfaces;
using Exercise2.Services;


namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChequeFormatter formatter = new ProtectedChequeFormatter();
            ChequePrinter printer = new ChequePrinter(formatter);

            Console.Write("Ingrese el monto del cheque: ");
            if (double.TryParse(Console.ReadLine(), out double monto))
            {
                printer.ImprimirMonto(monto);
            }
            else
            {
                Console.WriteLine("Monto inválido.");
            }
        }
    }
}
