using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoPessoas
{
    public class Pessoas
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double Carteira { get; set;}

        public List<Pessoas> ListaDePessoas { get; set; }
        public Pessoas()
        {

        }

        public List<Pessoas> RetornaListaCrescentePeloNome()
        {
            return ListaDePessoas.OrderBy(x => x.Nome).ToList<Pessoas>();
        }

        public List<Pessoas> RetornaListaDecrescentePelaData()
        {
            return ListaDePessoas.OrderByDescending(x => x.DataDeNascimento).ToList<Pessoas>();
        }

        public List<Pessoas> RetornaListaPessoasDinheiroMaiorQue()
        {
            return ListaDePessoas.FindAll(x => x.Carteira > 500);
        }

        public List<Pessoas> RetornaListaDeMaiorDeIdade()
        {
            return ListaDePessoas.
                FindAll(x => (DateTime.Now.Year - x.DataDeNascimento.Year) >= 18);
        }

        public List<Pessoas> RetornaListaDeMenorDeIdade()
        {
            return ListaDePessoas.
                FindAll(x => (DateTime.Now.Year - x.DataDeNascimento.Year) <= 16);
        }

    }
}
    

