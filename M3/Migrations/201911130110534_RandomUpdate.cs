namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RandomUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "street_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "city_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "state_address", c => c.String(nullable: false, maxLength: 2));
            AlterColumn("dbo.Customers", "email_address", c => c.String(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Customers", "email_address", c => c.String());
            AlterColumn("dbo.Customers", "state_address", c => c.String());
            AlterColumn("dbo.Customers", "city_address", c => c.String());
            AlterColumn("dbo.Customers", "street_address", c => c.String());
        }
    }
}
