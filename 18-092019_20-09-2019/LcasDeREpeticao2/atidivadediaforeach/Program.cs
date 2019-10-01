using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atidivadediaforeach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplitLista();
        }

        private static void ForeachComSplit02()
        {
            Console.WriteLine("Informe seu nome");

            var conteudoDoTexto = $"Aqui;temos;um;texto;que;iremos;mudar;para;uma;coleçãoe;vamos;colocar;isto;{Console.ReadLine()};para;depois;usar;com;o;replace";


                Console.WriteLine("Informe a palavra para realizar a busca");
                var palavra = Console.ReadLine();

            var conteudoTextoSplit = conteudoDoTexto.Split(';');
            // varre palavra por palavra da variavel declarada abaixo main
            foreach (var item in conteudoTextoSplit)

                {
                    if (palavra == item)
                        Console.WriteLine("Palavra encontrada com sucesso!");
                }
                Console.ReadKey();
            
        }
        ///<summary> metodo de busca com split e informando o nome

        private static void ForeachComSplitLista()
        {
            var conteudo = "nome:Silvana,idade:27;nome:Giomar,idade:75;nome:Eusebio,idade:29";
            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Usuários cadastrados no sistema");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
            Console.WriteLine("Informe um nome de sistema");
            var nomeBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                var inforacoesSplit = item.Split(',');

                var nome = inforacoesSplit[0].Split(':')[1];
                var idade = inforacoesSplit[1].Split(':')[1];
                if(nome == nomeBusca)
                {
                    Console.WriteLine($"O {nome} está com {idade} anos de idade.");
                }
            }
            Console.ReadKey();
        }
    }
}
