namespace WebApiimobiliaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cep = c.Int(),
                        Logradouro = c.String(maxLength: 50),
                        Bairrro = c.String(maxLength: 50),
                        Municipio = c.String(maxLength: 50),
                        Numero = c.Int(),
                        Complemento = c.String(maxLength: 50),
                        ProprietarioId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proprietario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 30),
                        DataNascimento = c.DateTime(),
                        Email = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Proprietario");
            DropTable("dbo.Imovel");
        }
    }
}
