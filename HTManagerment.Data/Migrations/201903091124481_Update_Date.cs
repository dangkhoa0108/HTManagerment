namespace HTManagerment.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_Date : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "DateModified", c => c.DateTime());
            AlterColumn("dbo.Settings", "DateModified", c => c.DateTime());
            AlterColumn("dbo.Units", "DateModified", c => c.DateTime());
            AlterColumn("dbo.Users", "DateModified", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "DateModified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Units", "DateModified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Settings", "DateModified", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Products", "DateModified", c => c.DateTime(nullable: false));
        }
    }
}
