namespace MyMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelOrder02 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Username", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Username", c => c.String());
        }
    }
}
