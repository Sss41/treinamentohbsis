using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Qual seu nome?");

            string nomecompleto = Console.ReadLine();

            Console.WriteLine($" {nomecompleto}");
            Console.ReadLine();


            Console.WriteLine(" Qual sua idade?");
            
            int idade = int.Parse (Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine($" Parabéns você é adulto");
                Console.ReadLine();

            }

            else
            {
              Console.WriteLine("Calma logo você será adulto!");
              Console.ReadKey();

            }

        }
    }
}
