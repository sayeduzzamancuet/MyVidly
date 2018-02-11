namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addGener : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "GenresId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "Genres_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Movies", "MovieName", c => c.String(nullable: false));
            CreateIndex("dbo.Movies", "Genres_Id");
            AddForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Genres_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "Genres_Id" });
            AlterColumn("dbo.Movies", "MovieName", c => c.String());
            DropColumn("dbo.Movies", "Genres_Id");
            DropColumn("dbo.Movies", "GenresId");
        }
    }
}
