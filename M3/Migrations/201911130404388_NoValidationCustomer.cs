namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class NoValidationCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(maxLength: 255));
            AlterColumn("dbo.Customers", "street_address", c => c.String());
            AlterColumn("dbo.Customers", "city_address", c => c.String());
            AlterColumn("dbo.Customers", "state_address", c => c.String(maxLength: 2));
            AlterColumn("dbo.Customers", "email_address", c => c.String());
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "email_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "state_address", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Customers", "city_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "street_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
