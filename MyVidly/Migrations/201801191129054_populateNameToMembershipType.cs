namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate,Name) values (1,0,0,0,'Pay as you go pack')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate,Name) values (2,30,1,10,'Monthly pack')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate,Name) values (3,90,3,15,'Three month pack')");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate,Name) values (4,120,12,20,'Four month pack')");
        }
        
        public override void Down()
        {
        }
    }
}
