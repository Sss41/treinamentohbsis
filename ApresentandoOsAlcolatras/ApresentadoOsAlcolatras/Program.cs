using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.Model;

namespace ApresentadoOsAlcolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();

        static void Main(string[] args)
        {

            cervejaController.GetCervejas().ForEach(x =>
             Console.WriteLine($"Id{x.Id}Nome{x.Nome}Litro{x.Litros}Valor{x.Valor}"));
            Console.ReadKey();

        }

    }
}
