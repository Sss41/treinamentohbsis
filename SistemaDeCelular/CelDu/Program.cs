using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;
using CatalogoCelulares.Controller;

namespace CelDu
{
    class Program
    { // 1 cstartar o projeto
        // adicionar eferencia
        //3- Adicionar o Entity ao projeto
        //4 adiconar using a nosso projeto Model,Controller
      static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;
            while(opcao != 0)
            {
                Console.WriteLine("Escolha  um menu.");
                Console.WriteLine("1-Inserir Celular.");
                Console.WriteLine("0-Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema");
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey(true);
                Console.Clear();
            }
        }
        //Inserir 
        public static void InserirCelular()
        {
            Console.WriteLine("---Inserir Celular");
            Console.WriteLine("Informe a narca do Celular");
            var marca = Console.ReadLine();

            Console.WriteLine("Informe o Modelo o Celular");
            var modelo = Console.ReadLine();

            Console.WriteLine(  "Informe valor do aparelho");
            var preco = double.Parse(Console.ReadLine());
            var resultado = celulares.InserirCelular(new Celular()    
            {
                Marca = marca,
                Modelo = modelo,
                Preco = preco

            });

            if (resultado) Console.WriteLine("Celular cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar aparelho!");
        }
        //Atualizar
        //Remover
        //Listar

    }
}
