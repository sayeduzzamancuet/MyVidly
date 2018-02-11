namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDatesToMovieModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "MovieName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "MovieName", c => c.String(nullable: false));
        }
    }
}
