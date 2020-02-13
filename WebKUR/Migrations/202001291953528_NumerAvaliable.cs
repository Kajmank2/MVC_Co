namespace WebKUR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NumerAvaliable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvaliable", c => c.Byte(nullable: false));
            Sql("Update Movies Set NumberAvaliable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvaliable");
        }
    }
}
