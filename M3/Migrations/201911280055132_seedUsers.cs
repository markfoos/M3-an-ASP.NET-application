namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5dd5f80c-e46a-408b-98e8-ef95dece98a4', N'admin@M3.com', 0, N'AJqnFymIzg5uFndKPltDtKaNJNzCyBSDX5JJf5xC5Gz9DWh/oDpKPjPDAXSfESv2yQ==', N'eecd1e90-5aa9-4371-8c00-fe4d717d5a7b', NULL, 0, 0, NULL, 1, 0, N'admin@M3.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ca8f63c0-ee34-4db3-9973-ccc3f289da49', N'employee@M3.com', 0, N'AHckZ26j0eKKiR5zqvqxD/LvQuWevDQALBTCqwVR2Epz91j1UVGH8hbe4H5FLyXNXQ==', N'ec2492da-90da-4db6-a075-17324eba9bcb', NULL, 0, 0, NULL, 1, 0, N'employee@M3.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a488410b-65a9-4892-a7c3-0f1c78707d13', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5dd5f80c-e46a-408b-98e8-ef95dece98a4', N'a488410b-65a9-4892-a7c3-0f1c78707d13')


");
        }
        
        public override void Down()
        {
        }
    }
}
