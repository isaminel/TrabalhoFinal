namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Operacaos", "NomeOperacao", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Operacaos", "NomeOperacao", c => c.String());
        }
    }
}
