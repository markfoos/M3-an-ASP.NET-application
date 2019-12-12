namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CusRestart6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));

        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
