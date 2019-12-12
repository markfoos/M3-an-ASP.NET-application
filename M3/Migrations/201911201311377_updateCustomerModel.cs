namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateCustomerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "issubscribed", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "IsSubscribedToNewletter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewletter", c => c.Boolean(nullable: false));
            DropColumn("dbo.Customers", "issubscribed");
        }
    }
}
