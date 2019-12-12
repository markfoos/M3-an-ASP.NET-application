namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class customerEntry1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.MembershipTypes", "Name", "name");

        }

        public override void Down()
        {

        }
    }
}
