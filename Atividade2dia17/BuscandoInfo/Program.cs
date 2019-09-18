using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace BuscandoInfo
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Digite uma das opcções abaixo:\n1-CriandoArvore\n2CalculoQuadrado\nListaCarros\nListaCervejas");
            MinhaBiblioteca01.CriandoArvore();
            MinhaBiblioteca01.CalculoDeAreaQuadrado();
            MinhaBiblioteca01.ListaCarros();
            MinhaBiblioteca01.ListaCervejas();
        }
    }
}
