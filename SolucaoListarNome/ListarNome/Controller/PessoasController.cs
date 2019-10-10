using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListarNome.Model;

namespace ListarNome.Controller
{
    public class PessoasController
    {
        PessoasContextDB contextDB = new PessoasContextDB();

        public IQueryable<NomePessoas>GetPessoas()
        {
            return contextDB .Pessoas.Where(x => x.Ativo == true);

        }

        public bool ListarPessoas(NomePessoas item)
        {
            var pessoa = contextDB.Pessoas.FirstOrDefault(x => x.Ativo ==NomePessoas);
            if (NomePessoas == null)
                return false;
        }


    } 
}
