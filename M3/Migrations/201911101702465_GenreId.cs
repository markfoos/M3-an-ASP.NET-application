namespace M3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreId : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (001,'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (002,'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (003,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (004,'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (005,'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (006,'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (007,'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (008,'Science Fiction')");
        }
    }
    
}
