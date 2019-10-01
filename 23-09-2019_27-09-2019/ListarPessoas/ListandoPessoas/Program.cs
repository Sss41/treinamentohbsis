using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            var classePessoa = new Pessoas();

            #region Pra isso que utiliza
            classePessoa.ListaDePessoas = new List<Pessoas>();

            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 1, Nome = "Spears  ",  DataDeNascimento = DateTime.Parse("07/11/2004"), Carteira = 846.96 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 2, Nome = "Swanson  ", DataDeNascimento = DateTime.Parse("20/06/2003"), Carteira = 233.09 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 3, Nome = "Gay      ", DataDeNascimento = DateTime.Parse("03/12/2001"), Carteira = 911.92 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 4, Nome = "Gregory  ", DataDeNascimento = DateTime.Parse("02/01/2000"), Carteira = 469.01 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 5, Nome = "Olson    ", DataDeNascimento = DateTime.Parse("18/07/2001"), Carteira = 261.90 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 6, Nome = "Garza    ", DataDeNascimento = DateTime.Parse("01/04/2000"), Carteira = 360.41 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 7, Nome = "Sweet    ", DataDeNascimento = DateTime.Parse("12/03/2003"), Carteira = 312.76 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 8, Nome = "Cline    ", DataDeNascimento = DateTime.Parse("26/03/2002"), Carteira = 484.51 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 9, Nome = "Oliver   ", DataDeNascimento = DateTime.Parse("05/07/2004"), Carteira = 513.76 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 10, Nome = "Vang     ",DataDeNascimento = DateTime.Parse("10/07/2000"), Carteira = 271.05 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 11, Nome = "Maddox   ",DataDeNascimento = DateTime.Parse("29/05/2004"), Carteira = 783.97 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 12, Nome = "Garrett  ",DataDeNascimento = DateTime.Parse("03/06/2006"), Carteira = 154.11 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 13, Nome = "Mcintosh ",DataDeNascimento = DateTime.Parse("06/07/2006"), Carteira = 902.80 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 14, Nome = "Yang     ",DataDeNascimento = DateTime.Parse("29/04/2005"), Carteira = 550.48 });
            classePessoa.ListaDePessoas.Add(new Pessoas()  { Id = 15,Nome ="Hendricks", DataDeNascimento = DateTime.Parse("05/09/2003"), Carteira = 410.56 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 16, Nome = "Cain     ",DataDeNascimento = DateTime.Parse("12/01/2002"), Carteira = 221.13 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 17, Nome = "Blackburn",DataDeNascimento = DateTime.Parse("10/05/2000"), Carteira = 135.67 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 18, Nome = "Howe     ",DataDeNascimento = DateTime.Parse("27/09/2005"), Carteira = 360.14 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 19, Nome = "Pratt    ",DataDeNascimento = DateTime.Parse("18/09/2000"), Carteira = 991.83 });
            classePessoa.ListaDePessoas.Add(new Pessoas() { Id = 20, Nome = "Sherman  ",DataDeNascimento = DateTime.Parse("20/02/2003"), Carteira = 667.00 });
            #endregion

            Console.WriteLine("Lista em ordem crescente pelo nome:");
            Console.ReadKey();

            classePessoa.RetornaListaCrescentePeloNome()
                .ForEach(i => ImprimeInformacao(i));

            Console.WriteLine("Lista em ordem decrescente pela data de nascimento:");
            Console.ReadKey();
            classePessoa.RetornaListaDecrescentePelaData()
                .ForEach(i => ImprimeInformacao(i));


            Console.WriteLine("Pessoas com mais de R$500,00 na carteira.");
            Console.ReadKey();
            classePessoa.RetornaListaPessoasDinheiroMaiorQue()
                .ForEach(i => ImprimeInformacao(i));


            Console.WriteLine("Pessoas maior de 18.");
            Console.ReadKey();
            classePessoa.RetornaListaDeMaiorDeIdade()
                .ForEach(i => ImprimeInformacao(i));


            Console.WriteLine("Pessoas menor de  16.");
            Console.ReadKey();
            classePessoa.RetornaListaDeMenorDeIdade()
                .ForEach(i => ImprimeInformacao(i));

            Console.ReadKey();
        }

        private static void ImprimeInformacao(Pessoas pessoa)
        {
            Console.WriteLine($"Id {pessoa.Id} Nome {pessoa.Nome} DataNascimento {pessoa.DataDeNascimento.ToShortDateString()} Carteira {pessoa.Carteira.ToString("N2")}");
            Console.WriteLine("-----------------------------------------------------");
        }
    }
}
