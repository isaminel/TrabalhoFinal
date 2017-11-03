namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidationContaCorrente2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ContaCorrentes", "Agencia", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.ContaCorrentes", "Titular", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ContaCorrentes", "Titular", c => c.String());
            AlterColumn("dbo.ContaCorrentes", "Agencia", c => c.String());
        }
    }
}
