using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListarNome.Controller;
using ListarNome.Model;


namespace InterfacePessos
{
     public class Program
    {

        static PessoasController pessoas = new PessoasController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0) 
            {
                Console.WriteLine("1- Listar nome.");
                Console.WriteLine("2- Inserir nome");
                Console.WriteLine("0-Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        ListarNomes();
                        break;
                    case 2:
                        InserirNomes();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema");
                        break;
                    default:
                        Console.WriteLine("Opção invalida.");
                        break;
                }

                Console.ReadKey(true);
                Console.Clear();

            }


            Console.WriteLine("Pressione qualquer tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();

        }
        public static void InserirNomes()
        {
            Console.WriteLine("Informe nome para inserir");
            var nome = Console.ReadLine();
            pessoas.InserirNomes(new NomePessoas()
            {
                Nome = nome
            });

            Console.WriteLine($"Nome:{nome} Nome inserido )");
        }
        public static void ListarNomes()
        {
            Console.WriteLine("Listar Nomes");
            pessoas.GetPessoas().ToList<NomePessoas>().ForEach(x => Console.WriteLine($"Nome:{ x.Nome}"));
            Console.ReadKey();
           
        }
    }

}
