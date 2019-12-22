namespace WebKUR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddbirthrdayToCoustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
