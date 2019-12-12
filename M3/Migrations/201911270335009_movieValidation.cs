namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Info", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Info", c => c.String());
        }
    }
}
