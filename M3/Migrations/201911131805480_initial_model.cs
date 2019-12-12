namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Customers",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Name = c.String(),
                   street_address = c.String(),
                   city_address = c.String(),
                   state_address = c.String(),
                   zip_address = c.Int(nullable: false),
                   phone_address = c.Long(nullable: false),
                   email_address = c.String(),
               })
               .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
            
        }
    }
}
