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

            Console.WriteLine("Qual seu nome completo?");
            string nomecompleto = Console.ReadLine();// variavel recebe o texto acima
            
            Console.WriteLine("Qual sua idade?");
            int idade = 0;//variavel recebe idade que usuaria ira digitar
            idade = int.Parse(Console.ReadLine());
                
            if (idade >= 18)
            {
                Console.WriteLine($" Parabéns você é adulto");
                Console.ReadLine();
            }
            else
            {
              Console.WriteLine($"Calma {nomecompleto} logo você será adulto! ");
              Console.ReadKey();
            }
        }
    }
}
