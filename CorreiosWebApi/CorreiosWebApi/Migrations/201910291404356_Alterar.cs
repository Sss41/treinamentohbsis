namespace CorreiosWebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alterar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enderecoes", "UF", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enderecoes", "UF", c => c.Double(nullable: false));
        }
    }
}
