using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDateTime();
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
        private static void ListaDeDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(3.75);
            minhaLista.Add(4.8);
            minhaLista.Add(2.42);
            minhaLista.Add(0.05);
            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal));
        }
    }
  
}
