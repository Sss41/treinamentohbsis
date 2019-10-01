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


            MostraIdentificador("Lista Ordenada");

            pessoaController
                .GetPessoasOrdenadaAsc()
                .ForEach(i => MostrandoInformacoes(i));
            MostraIdentificador("Lista Orndenada por nome");



            pessoaController
                .GetPessoasOrdenadaPelaDataDeNascimento()
                .ForEach(i => MostrandoInformacoes(i));

            MostraIdentificador("Lista Orndenada por Data de Nascimento");


            pessoaController
                .GetPessoasComMaisDonheiro()
                .ForEach(i => MostrandoInformacoes(i));

            MostraIdentificador("Lista pessoas com mais dinheiro");



            pessoaController
                .GetPessoasComIdadeMaiorA()
                .ForEach(i => MostrandoInformacoes(i));
            MostraIdentificador("Lista Pessoas com idade maior de 18");

            MostraIdentificador("Lista dos Menores de 16 Anos");
            pessoaController.GetPessoasComIdadeMenorA().ForEach(i => MostrandoInformacoes(i));




            Console.ReadKey();
        }
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("-------{0,20}-------", nomeAcao));
        }
        private static void MostrandoInformacoes(Pessoa i)
        {
            string template = "Id {0,3} Nome {1,10} Nascimento{2,10} Carteira{3,5}";

            string textoFormatado = string.Format(template,
                 i.Id,
                 i.Nome,
                 i.DataDeNascimento.ToShortDateString(),
                 i.Carteira.ToString("C"));
                 

            Console.WriteLine(textoFormatado);
        }   
    }
}
