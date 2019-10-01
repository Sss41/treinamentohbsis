using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MinhaBiblioteca01
    {
        public static void CriandoArvore()
        {
            Console.WriteLine("        (*)");
            Console.WriteLine("       (***)");
            Console.WriteLine("       (***)");
            Console.WriteLine("      (*****)");
            Console.WriteLine("      (******)         ");
            Console.WriteLine("     (********)       ");
            Console.WriteLine("     (*********)      ");
            Console.WriteLine("    (***********)     ");
            Console.WriteLine("    (************)");
            Console.WriteLine("        |     |");
            Console.WriteLine("        |     |");
            Console.WriteLine("        |     |");
            Console.WriteLine("        |     |");
            Console.WriteLine(@"      /      \");
            Console.ReadKey();
        }

        public static void CalculoDeAreaQuadrado()
        {


            Console.WriteLine("Informe o tamanho de um dos lados do quadrado:");
            double lado = double.Parse(Console.ReadLine());
            //double area = lado * lado;
            Console.WriteLine($"A área do quadrado é:{lado * lado}");
            Console.ReadKey();


        }

        public static void ListaCervejas()
        {
            var minhaLista = new List<string>();

            minhaLista.Add("Budweiser.");
            minhaLista.Add("Corona.");
            minhaLista.Add("Brahama.");
            minhaLista.Add("Skol.");

            minhaLista.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }

        public static void ListaCarros()
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
