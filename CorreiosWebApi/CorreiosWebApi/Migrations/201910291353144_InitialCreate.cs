namespace CorreiosWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(),
                        Bairro = c.String(),
                        Cep = c.Double(nullable: false),
                        UF = c.Double(nullable: false),
                        Complemento = c.String(),
                        Municipio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Enderecoes");
        }
    }
}
