using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Venda> vendas = new List<Venda>()
            {
                new Venda()
                {
                    produto = "XIAOMI Lite 6 quad Core 128gb 32px frontal",
                    Quantidade = 8,
                    Valor = 1200.75
                },
                new Venda()
                {
                    produto = "Slim 3500 APP",
                    Quantidade = 1,
                    Valor = 2800.95
                },

                 new Venda()
                {
                    produto = "IPHONE FOGÃO",
                    Quantidade = 1,
                    Valor = 9999.99
                }
            };
            Console.WriteLine("Media de produtos vendidos neste mês.");
            Console.WriteLine(vendas.Average(x => x.Quantidade));
            Console.WriteLine("Media total de vendas neste mês em R$");
            Console.WriteLine(vendas.
                //Aqui realizamos o calculo de quantidade * valor = total de venda do produto
                Average(x =>(x.Quantidade * x.Valor)));

            Console.ReadKey();
        }
    }
}
