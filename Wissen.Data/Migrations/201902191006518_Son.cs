namespace Wissen.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Son : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Description", c => c.String(nullable: false));
        }
    }
}
