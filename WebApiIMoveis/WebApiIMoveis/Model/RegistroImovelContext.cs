using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiIMoveis.Model;

namespace WebApiIMoveis.Model
{
    public class RegistroImovelContext: DbContext
    {
       
       
            public RegistroImovelContext(DbContextOptions<RegistroImovelContext> options)
                : base(options)
            {

            }
            public DbSet<Imovel> Imovels { get; set; }
            public DbSet<Proprietario> Proprietario { get; set; }
        
    }
}
