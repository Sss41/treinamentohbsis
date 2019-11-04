using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEbApiNetCore.Model
{
    public class webApiContext : DbContext
    {
        public webApiContext(DbContextOptions<webApiContext>options)
            : base(options)
        { 
          
        }
        public DbSet<Bicicleta> Bicicleta { get; set; }
    }
}
