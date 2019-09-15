using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira um texto: ");
            var texto = Console.ReadLine();
            int quantidade = texto.Length;
            char pricaracter = ' ', ultimocaracter = ' ';
            int a = 0;
            for (int i = 0; i < quantidade; i++)
            {
                if (i == 0)//se for a primeira letra, salva na primeira
                {
                    pricaracter = texto[i];
                }
                a = i;
            }
            ultimocaracter = texto[a];
            Console.WriteLine($"o primeiro caracter é '{pricaracter}' e o ultimo é: '{ultimocaracter}'");
            Console.ReadKey();
        }
    }
}
