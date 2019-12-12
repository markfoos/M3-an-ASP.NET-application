namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class MembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewletter", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewletter");
        }
    }
}