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
            Console.WriteLine("Digite seu nome");
            var nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade>= 18)
            {
                Console.WriteLine($"Parabéns {nomeCompleto} já pode namorar");
            }
            else
            {
                Console.WriteLine($"Calma {nomeCompleto} Logo você poderá namorar!!!!");
            }


            Console.ReadKey();
        }

       
      
    }
}
