namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.ContaCorrentes", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Gerentes", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Operacaos", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operacaos", "IsSubscribedToNewsletter");
            DropColumn("dbo.Gerentes", "IsSubscribedToNewsletter");
            DropColumn("dbo.ContaCorrentes", "IsSubscribedToNewsletter");
            DropColumn("dbo.Clientes", "IsSubscribedToNewsletter");
        }
    }
}
