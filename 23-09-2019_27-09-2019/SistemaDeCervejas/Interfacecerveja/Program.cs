using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCerveja.Controller;
using ListagemDeCerveja.Model;




namespace Interfacecerveja
{
    class Program
    {
        private static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            MostraMenu();


        }
        private static void MostraMenu()
        {
            //Console.Clear();
            Console.WriteLine("Sistema de cerveja");
            Console.WriteLine("Mostrar Menu");
            Console.WriteLine("0-Sair");
            Console.WriteLine("1-Mostrar Lista");
            Console.WriteLine("2-Mostrar valor total da lista.");
            Console.WriteLine("3-Mostrar valor total de litros de cerveja.");



            var menuEscolhido = int.MinValue;

            while (menuEscolhido != 0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch (menuEscolhido)
                {
                    case 1:

                        MostraLista();
                        MostraMenu();
                        break;
                    case 2:
                        MostrarValorTotal();
                        MostraMenu();
                        break;
                    case 3:
                        MostrarValorLitro();
                        MostraMenu();
                        break;
                    case 4:
                        AdicionarCerveja();
                        MostraMenu();
                        break;
                    case 0:
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Valor invalido, digite novamente.\n");
                        MostraMenu();
                        break;
                }
            }
        }

        private static void AdicionarCerveja()
        {
            Console.WriteLine("Digite um nome de cerveja para adicionar");
            var Nome = Console.ReadLine();

            Console.WriteLine("Digite um valor para adicionar");
             double valor = double.Parse (Console.ReadLine());

            Console.WriteLine("Digite quantidade de litros");
            double litros = double.Parse(Console.ReadLine());


            Console.WriteLine("Digite quantidade de alcool por litro.");
            double alcool = double.Parse(Console.ReadLine());

            cervejaController.AdicionarCerveja(
                new Cerveja()
                {
                    Nome = Nome,
                    Litros = litros,
                    Valor = valor,
                    Alcool = alcool
                    
                });
         }
        

        private static void MostrarValorLitro()
        {
            Console.Clear();
            var valor = cervejaController.ListaCerveja().Sum(x => x.Litros);
            Console.WriteLine($"Valor total de litros de cerveja é: {valor}");
            Console.ReadKey();
        }

        private static void MostrarValorTotal()
        {
            Console.Clear();
            var valor = cervejaController.ListaCerveja().Sum(x=> x.Valor);
            Console.WriteLine($"Valor total da lista é: {valor.ToString("C2")}");
            Console.ReadKey();
        }

        private static void MostraLista()
        {
            Console.Clear();
            cervejaController.ListaCerveja().ForEach(x => Console.WriteLine(string.Format("Nome:{0,-20}Preço:{1,-95}Volume:{2,6}",x.Nome,x.Valor,x.Litros)));
            Console.ReadKey();
        }
  
    }
    
}
