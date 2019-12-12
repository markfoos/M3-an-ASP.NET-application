namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class CusRestart8 : DbMigration
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
