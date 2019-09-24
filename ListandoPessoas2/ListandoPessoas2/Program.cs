using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListandoPessoas2.Controller;
using ListandoPessoas2.Model;

namespace ListandoPessoas2
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaController pessoaController
              
                
                = new PessoaController();


            pessoaController.ListaDePessoasPublica.ForEach(i => MostrandoInformacoes(i));


            
            Console.ReadKey();
        }
        private static void MostrandoInformacoes(Pessoa i)
        {
            string template = "Id {0,3} Nome {1,10}";

            string textoFormatado = string.Format(template, i.Id, i.Nome);

            Console.WriteLine(textoFormatado);
        }   
    }
}
