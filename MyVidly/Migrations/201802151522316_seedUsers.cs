namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
        INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'1d849a30-93b9-44b3-b3e2-3f1efa8e956f', N'guest', N'APwQnk0f5bixP6jaxslxtN7otDTDIYEfGi6O2kxgjtE9cJf2+VCAIu0D7o59mUoWhA==', N'ed5d3bc3-ce96-42cc-8a6e-c2e0b04baa2d', N'ApplicationUser')
        INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [PasswordHash], [SecurityStamp], [Discriminator]) VALUES (N'6abd98c6-2362-4089-bb83-34c84f50e055', N'admin', N'APqEp5O2RdPlFf43EX0YUBAC7jkO0raDwUoPOUfk7F+cvvfTr/K3Lo066HWmVh+YMA==', N'37998bfe-93ef-466f-a524-dd71d104d2fb', N'ApplicationUser')
        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c3346869-7db3-4259-b603-1c7a9a827637', N'CanManageMovies')
        INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6abd98c6-2362-4089-bb83-34c84f50e055', N'c3346869-7db3-4259-b603-1c7a9a827637')

        ");
        }

        public override void Down()
        {
        }
    }
}
