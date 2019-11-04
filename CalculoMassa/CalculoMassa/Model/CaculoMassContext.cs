using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoMassa.Model
{
    public class CaculoMassContext : DbContext
    {
        public CaculoMassContext(DbContextOptions<CaculoMassContext> options)
            : base(options)
        {

        }
        public DbSet<Massa> Massas { get; set; }
    }
}
