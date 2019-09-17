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
            Console.WriteLine("Insira um texto: ");
            var texto = Console.ReadLine();
            int quantidade = texto.Length;

            Console.WriteLine($"tamanho do texto inserido: {texto.Length}");
            Console.ReadKey();
        }
    }
}