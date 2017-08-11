using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Começando os Numeros Romanos...");
            Romanos romano = new Romanos();
            string numeroDigitado = Console.ReadLine();
            int conversao = Int32.Parse(numeroDigitado);
            romano.CriarNumeroRomano(conversao);
            Console.WriteLine("Finished....");
            Console.ReadKey();

        }
    }
}
