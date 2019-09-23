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
            var ListaPessoas = new List<Pessoas>();
            ListaPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Spears",
                DataDeNascimento = DateTime.Parse(" 07/11/2004").ToString(),
                Carteira = "846.96",
            }) ;

            ListaPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Swanson",
                DataDeNascimento = DateTime.Parse(" 20/06/2006").ToString(),
                Carteira = "233.09",
            });

            ListaPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Gay",
                DataDeNascimento = DateTime.Parse("03/12/2011").ToString(),
                Carteira = "911.02",
            });
            ListaPessoas.OrderByDescending(x => x.Nome).ToList<Pessoas>().ForEach(i =>
               Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Data de nascimento: {i.DataDeNascimento} DateTime.ToString (dd / MM / yyyy)"));
            Console.ReadKey();


           ListaPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Spears",
                DataDeNascimento = DateTime.Parse(" 07/11/2004").ToString(),
                Carteira = "846.96",
            });


            ListaPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Swanson",
                DataDeNascimento = DateTime.Parse(" 20/06/2006").ToString(),
                Carteira = "233.09",
            });


            ListaPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Gay",
                DataDeNascimento = DateTime.Parse("03/12/2011").ToString(),
                Carteira = "911.02",
            });
            ListaPessoas.OrderByDescending(x => x.Nome).ToList<Pessoas>().ForEach(i =>
              Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Data de nascimento: {i.DataDeNascimento} DateTime.ToString (dd / MM / yyyy)"));
            Console.ReadKey();

        }
    }
}
