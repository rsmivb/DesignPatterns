using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Romanos
    {
        public void CriarNumeroRomano(int numero)
        {
            string resultado = string.Empty;
            resultado += NumeroRomanoMilhar(numero / 1000);
            resultado += NumeroRomanoCentena((numero % 1000) / 100);
            resultado += NumeroRomanoDecimal(((numero % 1000) % 100) / 10);
            resultado += NumeroRomanoUnitario(((numero % 1000) % 100) % 10);

            Console.WriteLine($"O número {numero} em Romanos é {resultado}");
        }

        public string NumeroRomanoUnitario(int unitario)
        {
            switch (unitario)
            {
                case 1: return "I";
                case 2: return "II";
                case 3: return "III";
                case 4: return "IV";
                case 5: return "V";
                case 6: return "VI";
                case 7: return "VII";
                case 8: return "VIII";
                case 9: return "IX";
                default:
                    return "";
            }
        }
        public string NumeroRomanoDecimal(int numDecimal)
        {
            switch (numDecimal)
            {
                case 1: return "X";
                case 2: return "XX";
                case 3: return "XXX";
                case 4: return "XL";
                case 5: return "L";
                case 6: return "LX";
                case 7: return "LXX";
                case 8: return "LXXX";
                case 9: return "XC";
                default:
                    return "";
            }
        }
        public string NumeroRomanoCentena(int centena)
        {
            switch (centena)
            {
                case 1: return "C";
                case 2: return "CC";
                case 3: return "CCC";
                case 4: return "CD";
                case 5: return "D";
                case 6: return "DC";
                case 7: return "DCC";
                case 8: return "DCCC";
                case 9: return "CM";
                default:
                    return "";
            }
        }
        public string NumeroRomanoMilhar(int milhar)
        {
            switch (milhar)
            {
                case 1: return "M";
                case 2: return "MM";
                case 3: return "MMM";
                default:
                    return "";
            }
        }
    }

    public enum Ordem
    {
        Milhar = 1000,
        Centena = 100,
        Dezena = 10,
        Unidade = 1
    }
}
