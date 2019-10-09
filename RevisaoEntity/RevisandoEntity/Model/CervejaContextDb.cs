using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RevisandoEntity.Model
{
     public class CervejaContextDb :
        DbContext
    {
        public DbSet<Cerveja> Cervejas { get; set; }// DbSet representa uma tabelas /entidade= cerveja.
    }
}
