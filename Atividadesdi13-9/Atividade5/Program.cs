using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira um texto qualquer");
            var texto = Console.ReadLine();//aqui esou lendo o texto dentro dos parentes
            char primcaracter, ultimacaracter;
            int a = 0;
            int quantidade = texto.Length;


            Console.WriteLine($" Esse texto tem {quantidade} ");
            Console.ReadKey();

        }
    }
}
