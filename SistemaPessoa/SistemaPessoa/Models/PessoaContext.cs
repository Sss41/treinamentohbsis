namespace SistemaPessoa.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PessoaContext : DbContext
    {
        
        public PessoaContext()
            : base("name=PessoaContext")
        {
        }

        
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Pessoa> Pessoas { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}