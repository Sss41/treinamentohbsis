using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infirmcaoesdocarro
{
    class Program
    {
        static void Main(string[] args)
        {

            ForeachComSplitLista();
        }

        private static void ForeachComSplit02()
        {

        }

        private static void ForeachComSplitLista()
        {
            var conteudo = "carro:Gol,marca:volkswagen,ano:2000;carro:Jetta,marca:volkswagen,ano:2012;carro:Sportage,marca:Kia,ano:2011;carro:Hb20,marca:hyundai,ano:2015";
            var listaDeInformacoes = conteudo.Split(';');
            Console.WriteLine("Marca do carro");
            foreach (var item in listaDeInformacoes)
            {
                Console.WriteLine(item.Split(',')[0]);
            }
           
            Console.WriteLine("Informe nome do carro");
            var marcaBusca = Console.ReadLine();

            foreach (var item in listaDeInformacoes)
            {
                // o split quebra as informcoes em partes menores(strings menores)
                var inforacoesSplit = item.Split(',');
             
                var carro = inforacoesSplit[0].Split(':')[1];
                var ano = inforacoesSplit[2].Split(':')[1];
                

                if (carro == marcaBusca)
                {
                    Console.WriteLine($"Nome do carro: {carro},{ano} .");
                }
            }
            Console.ReadKey();
        }
    }
}
