using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividad2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Seja bem vindo");

            //string nome = AsKtToName();
            Console.WriteLine("Seja bem vindo");
            Console.WriteLine("Digite seu nome");
            var nomeCompleto = Console.ReadLine();

            Console.WriteLine($"Bem vindo {nomeCompleto}");
           

            Console.ReadKey( );
              
        }

        public static string AsKtToName()
        {
            Console.WriteLine("Digite seu nome");
            return Console.ReadLine();
        }
    }
}
