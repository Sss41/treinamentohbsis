using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CalculoAreaQuadrado   
{
   public  class Program { 
        public static void Main(string[] args)
    {

        //CriandoArvore.CriaArvore.CriandoArvore();
    }


        public static void CalculoDeAreaQuadrado()
        {
           

            Console.WriteLine("Informe o tamanho de um dos lados do quadrado:");
            var lado = double.Parse(Console.ReadLine());
            //double area = lado * lado;
            Console.WriteLine($"A área do quadrado é:{lado * lado}");
            Console.ReadKey();
           

        }

    }
}
