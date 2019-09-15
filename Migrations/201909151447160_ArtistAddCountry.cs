namespace MyMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArtistAddCountry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artists", "Country", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Artists", "Country");
        }
    }
}
