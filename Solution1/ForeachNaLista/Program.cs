using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListaDeNumerosReais();
            //ListaNumerosEuro();
            // ListaNumerosYen();
            ListaNumerosBitCoin();

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhaLista = new List<DateTime>();

            minhaLista.Add(new DateTime(2019, 9, 17));
            minhaLista.Add(new DateTime(2019, 9, 18));
            minhaLista.Add(new DateTime(2019, 9, 19));
            minhaLista.Add(new DateTime(2019, 9, 20));
            minhaLista.ForEach(minhaData => Console.WriteLine(minhaData.ToLongDateString()));


        }
        ///sumary
        ///mostra lista de string definidas
        ////sumary
        private static void ListaString()
        {
            var minhaLista = new List<string>();
            minhaLista.Add("XIAOMI");
            minhaLista.Add("IPHONE APPLE");
            minhaLista.Add("SAMSUNG");
            minhaLista.Add("NOKIA");

            minhaLista.ForEach(i => Console.WriteLine(i));


        }
        private static void ListaInteiro()
        {
            var minhaLista = new List<int>();
            minhaLista.Add(17);
            minhaLista.Add(18);
            minhaLista.Add(19);
            minhaLista.Add(20);

            minhaLista.ForEach(meuNumero => Console.WriteLine(meuNumero));


        }
        /// minha lista de decimais
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.8);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal));
        }
        private static void ListaDeNumerosReais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.8);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + ""+ FormataNumeroDecimaEmDolar(meuDecimal)));
        }
        private static string FormataNumeroDecimaEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C",CultureInfo.CreateSpecificCulture("en-US"));
        }
        private static void ListaNumerosEuro()
        {

            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.8);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " " + FormataNumeroDecimaEmEuro(meuDecimal)));
        }
        private static string FormataNumeroDecimaEmEuro(double meuNumero)
        {
            return (meuNumero / 5.12).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "Euro");
        }
        private static void ListaNumerosYen()
        {

            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.8);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " " + FormataNumeroDecimaEmYen(meuDecimal)));
        }
        /// <summary>
        ///  metodo que converte meu numero em real para Yen
        /// </summary>
        /// <param name="meuNumero"></param>
        /// <returns></returns>Retorna meu numero formatado em Yen
        private static string FormataNumeroDecimaEmYen(double meuNumero)
        {
           return(meuNumero / 5.12).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

        private static void ListaNumerosBitCoin()
        {

            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.8);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal.ToString("C") + " " + FormataNumeroDecimaEmBitCoin(meuDecimal)));
        }
        /// <summary>
        /// metodo que converte meu numero em real para Bitcoin
        /// </summary>
        /// <param name="meuNumero"> meu numer em real</param>
        /// <returns></returns>Retorna meu numero formatado em Btcoin
        private static string FormataNumeroDecimaEmBitCoin(double meuNumero)
        {
            return (meuNumero / 41897.97).ToString("C10", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "BTC");
        }
    }


}
