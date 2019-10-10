using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListarNome.Model 
{
     public class NomeContextDB : DbContext
    {
        public Dbset<Nome> Nomes { get; set; }
    }
}
