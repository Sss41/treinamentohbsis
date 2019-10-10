using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarNome.Model
{
  public  class PessoasContextDB : DbContext
    {
        public DbSet<NomePessoas> Pessoas { get; set; }
    }
}
