using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeListarCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCarros();
        }
        private static void ListaCarros()
        {
            var minhaLista = new List<string>();
            Console.WriteLine("Informe a marca do carro:");
            minhaLista.Add(Console.ReadLine());

            Console.WriteLine("Informe outra marca do carro:");
            minhaLista.Add(Console.ReadLine());

            Console.WriteLine("Informe outra marca do carro:");
            minhaLista.Add(Console.ReadLine());

            Console.WriteLine("Informe outra marca do carro:");
            minhaLista.Add(Console.ReadLine());

            Console.WriteLine("Informe outra marca do carro:");
            minhaLista.Add(Console.ReadLine());

            //            minhaLista.Add("Fiat.");
            //            minhaLista.Add("Renault.");
            //            minhaLista.Add("Chevrolet.");
            //            minhaLista.Add("Peugeout.");


            minhaLista.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
    }
}
