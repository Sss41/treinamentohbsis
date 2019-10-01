using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3dia17
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCervejas();
        }
        private static void ListaCervejas()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("Budweiser.");
            minhaLista.Add("Corona.");
            minhaLista.Add("Brahama.");
            minhaLista.Add("Skol.");

            minhaLista.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}