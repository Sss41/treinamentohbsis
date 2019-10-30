namespace WebApiimobiliaria.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            
        }

        public virtual DbSet<Imovel> Imovel { get; set; }
        public virtual DbSet<Proprietario> Proprietario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
