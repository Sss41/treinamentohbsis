namespace WebApiimobiliaria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiimobiliaria.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiimobiliaria.Models.Model1 context)
        {
            context.Proprietario.AddOrUpdate(x => x.Nome, new Models.Proprietario()
            {
                Nome= "Silvana",
                DataNascimento=DateTime.Parse("2019/2/18"),              
                Email = "admin@admin",
                
            });

            context.Imovel.AddOrUpdate(x => x.Logradouro, new Models.Imovel()
            {
                Cep=89037586,
                Bairrro="Escola",
                Logradouro="Maria dos Santos Pacheco",
                Complemento="Casa tres",
                Municipio="Blumenau",
                Numero=856,
                ProprietarioId=1,
                

            });
            context.SaveChanges();
        }
    }
}
