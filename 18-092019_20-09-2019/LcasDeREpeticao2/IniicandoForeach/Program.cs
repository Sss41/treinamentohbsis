using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniicandoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit();
        }
        /// <summary>
        /// metodo que mostra como podemos utilizar o foreach pra andar sobre cada palavra
        /// </summary>

        private static void IniciandoForeacho1()
        {

            Console.WriteLine("Informar texto");
            var conteudoDoTExto = Console.ReadLine();

            foreach (var item in conteudoDoTExto)
            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "Aqui vou colocar meu nome Silvana para  realizar a busca";

            Console.WriteLine("Informe a palavra para realizar a busca");
            var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(' ');

            foreach (var item in conteudoTextoSplit)
            {
                if(palavra  == item)
                    Console.WriteLine("Palavra enconrada com sucesso!");
            }
            Console.ReadKey();
        }
    }
}