namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationGerente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Gerentes", "Nome", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gerentes", "Cpf", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Gerentes", "Cpf", c => c.String());
            AlterColumn("dbo.Gerentes", "Nome", c => c.String());
        }
    }
}
