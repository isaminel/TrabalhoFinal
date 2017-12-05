namespace TrabalhoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inserts : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], 
[PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], 
[UserName]) VALUES (N'7b012c56-b14e-43b3-baad-b1bfe90e4e49', N'admin@admin.com', 0,
N'ABJiFtjXfmsrFky0IBYHL9t+4AVUEgUvUoYIV9D6sJ74ClnURvl+VBJBq9DvF+HroQ==', N'3bf0345d-587e-4cf1-9177-7268b72d616d', 
NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6da89626-76c7-4d65-8f00-7a8567d6d0ea', N'rodrigo@gmail.com', 0, N'AChcg2mwObJvX6Mj4kouEuVsju+M5VVKjOqXbmT9xvRwfsO+BTTTTkn7mcqTJlFglg==', N'f1c4f640-1841-4416-90a4-f8b3b5753cd3', NULL, 0, 0, NULL, 1, 0, N'rodrigo@gmail.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'eaafa8b8-e6de-45a2-bf0e-af6e9e051d11', N'CanManageCustomers')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7b012c56-b14e-43b3-baad-b1bfe90e4e49', N'eaafa8b8-e6de-45a2-bf0e-af6e9e051d11')
");

           
        }
        
        public override void Down()
        {
        }
    }
}
