namespace WebKUR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a35a0583-f126-4559-8f13-54fb03c1834b', N'testkarshop1@gmail.com', 0, N'ANZme2iOot+VvA2vcb3aXvmIGDDGJ8d7EMxOIDwXaJuC6AHGsBXmAwsdQLW8a1T/ng==', N'3b81bcb9-ee49-456c-b4fb-47babd0168c0', NULL, 0, 0, NULL, 1, 0, N'testkarshop1@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a8b52fc3-89d9-4001-9bde-93f416d095cd', N'teskarshop@gmai.com', 0, N'AMyfTyVmOUGLpezYeC3ehuli4FOYk+I4n3bb/Jg9Pb67c3W6nTGay9IzZsMCovFeBg==', N'07346c2f-f410-4af0-ae9b-b73f995ee90b', NULL, 0, 0, NULL, 1, 0, N'teskarshop@gmai.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1951bebf-8a6c-4710-8398-e4931142b010', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a8b52fc3-89d9-4001-9bde-93f416d095cd', N'1951bebf-8a6c-4710-8398-e4931142b010')

");
        }
        
        public override void Down()
        {
        }
    }
}
