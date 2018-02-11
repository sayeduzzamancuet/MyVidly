namespace MyVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGeneres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) values ('Action')");
            Sql("INSERT INTO Genres (Name) values ('Drama')");
            Sql("INSERT INTO Genres (Name) values ('Comedy')");
            Sql("INSERT INTO Genres (Name) values ('Romance')");
            Sql("INSERT INTO Genres (Name) values ('Horror')");
            Sql("INSERT INTO Genres (Name) values ('Biography')");
            Sql("INSERT INTO Genres (Name) values ('Sci-fi')");
           
        }
        
        public override void Down()
        {
        }
    }
}
