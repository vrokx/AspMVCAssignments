namespace Assignment1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FootBallLeagueDB : DbMigration
    {
        public override void Up()
        {
            Sql("DBCC CHECKIDENT ('FootBallLeagues', RESEED, 1001)");
        }
        
        public override void Down()
        {
        }
    }
}
