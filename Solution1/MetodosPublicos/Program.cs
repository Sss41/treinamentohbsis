using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace MetodosPublicos
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("---Sistema conversor de moedas cabuloso");
            Console.WriteLine("Informe um valor a ser convertido");

            var valorAserConvertido = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe moeda para conversão:");
            Console.WriteLine("Dolar,EURO,YEN,BTC");

            var moedaAlvoParaConverter = Console.ReadLine();
            ConvertMoeda(valorAserConvertido, moedaAlvoParaConverter);
        }

        /// <summary>
        /// metodo que converte moeda em real para alvo especificado
        /// para converter digite os lvos:
        /// "Euro"
        /// "YEN"
        /// "BTC"
        /// "Dolar"
        /// </summary>
        /// <param name="minhaMoeda">moeda em valor real</param>
        /// <param name="moedaAlvo">alvo em que a moeda sera convertida</param>
        public static void ConvertMoeda(double minhaMoeda, string moedaAlvo)
        {
            switch (moedaAlvo)
            {
                case "Dolar":
                    Console.WriteLine(FormataNumeroDecimaEmDolar(minhaMoeda));
                    break;
                case "Euro":
                    Console.WriteLine(FormataNumeroDecimaEmEuro(minhaMoeda));
                    break;
                default:
                    break;
            }
                
        }
        private static string FormataNumeroDecimaEmBitCoin(double meuNumero)
        {
            return (meuNumero / 41897.97).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC");

        }
        private static string FormataNumeroDecimaEmYen(double meuNumero)
        {
            return (meuNumero / 5.12).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        private static string FormataNumeroDecimaEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
        }
        private static string FormataNumeroDecimaEmEuro(double meuNumero)
        {
            return (meuNumero / 5.12).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro");
        }
    }
}