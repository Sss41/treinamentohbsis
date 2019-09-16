using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um texto contendo a palavra banana.");
            var texto1 = Console.ReadLine();
            texto1  = texto1.Replace("banana", "Laranja");//reaplace troca o 1° parametro pelo 2° parametro e armazena no texto.Replace
            Console.WriteLine(texto1);
            Console.ReadKey();
        }
    }
}
