using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2dia17
{
    class Program
    {
        static void Main(string[] args)
        {
            calculoDeAreaQuadrado();
            
        }
        private static void calculoDeAreaQuadrado()
        {
           

            Console.WriteLine("Informe o tamanho de um dos lados do quadrado:");
            var lado = double.Parse(Console.ReadLine());
            //double area = lado * lado;
            Console.WriteLine($"A área do quadrado é:{lado * lado}");
            Console.ReadKey();
           

        }

    }
}
