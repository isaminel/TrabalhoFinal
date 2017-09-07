namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.ContaCorrentes", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Gerentes", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Operacaos", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Clientes", new[] { "MembershipTypeId" });
            DropIndex("dbo.ContaCorrentes", new[] { "MembershipTypeId" });
            DropIndex("dbo.Gerentes", new[] { "MembershipTypeId" });
            DropIndex("dbo.Operacaos", new[] { "MembershipTypeId" });
            DropColumn("dbo.Clientes", "IsSubscribedToNewsletter");
            DropColumn("dbo.Clientes", "MembershipTypeId");
            DropColumn("dbo.ContaCorrentes", "IsSubscribedToNewsletter");
            DropColumn("dbo.ContaCorrentes", "MembershipTypeId");
            DropColumn("dbo.Gerentes", "IsSubscribedToNewsletter");
            DropColumn("dbo.Gerentes", "MembershipTypeId");
            DropColumn("dbo.Operacaos", "IsSubscribedToNewsletter");
            DropColumn("dbo.Operacaos", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Operacaos", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Operacaos", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Gerentes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Gerentes", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.ContaCorrentes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.ContaCorrentes", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Clientes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Clientes", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Operacaos", "MembershipTypeId");
            CreateIndex("dbo.Gerentes", "MembershipTypeId");
            CreateIndex("dbo.ContaCorrentes", "MembershipTypeId");
            CreateIndex("dbo.Clientes", "MembershipTypeId");
            AddForeignKey("dbo.Operacaos", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gerentes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ContaCorrentes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
