using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo. Qual seu nome completo?");

            string nomecompleto = Console.ReadLine();

            Console.WriteLine($"Bem vindo: {nomecompleto}");
            Console.ReadLine();
        }
    }
}
