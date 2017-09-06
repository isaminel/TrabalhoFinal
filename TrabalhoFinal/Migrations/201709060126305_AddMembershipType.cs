namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
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
            
            AddColumn("dbo.Clientes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.ContaCorrentes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Gerentes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Operacaos", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Clientes", "MembershipTypeId");
            CreateIndex("dbo.ContaCorrentes", "MembershipTypeId");
            CreateIndex("dbo.Gerentes", "MembershipTypeId");
            CreateIndex("dbo.Operacaos", "MembershipTypeId");
            AddForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ContaCorrentes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Gerentes", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Operacaos", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Operacaos", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Gerentes", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.ContaCorrentes", "MembershipTypeId", "dbo.MembershipTypes");
            DropForeignKey("dbo.Clientes", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Operacaos", new[] { "MembershipTypeId" });
            DropIndex("dbo.Gerentes", new[] { "MembershipTypeId" });
            DropIndex("dbo.ContaCorrentes", new[] { "MembershipTypeId" });
            DropIndex("dbo.Clientes", new[] { "MembershipTypeId" });
            DropColumn("dbo.Operacaos", "MembershipTypeId");
            DropColumn("dbo.Gerentes", "MembershipTypeId");
            DropColumn("dbo.ContaCorrentes", "MembershipTypeId");
            DropColumn("dbo.Clientes", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
}
