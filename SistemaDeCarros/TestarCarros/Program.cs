using ListagemDeCarros.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestarCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroController carroController = new CarroController();
            carroController.Listar().ForEach(x => Console.WriteLine($"Id {x.Id} Marca {x.Marca}"));
            Console.ReadKey();
        }
    }
}
