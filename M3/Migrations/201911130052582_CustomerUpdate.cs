namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CustomerUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthdate", c => c.DateTime());
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "birthdate");
        }
    }
}
