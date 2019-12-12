namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customervalidation3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "phone_address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "phone_address", c => c.Long(nullable: false));
        }
    }
}
