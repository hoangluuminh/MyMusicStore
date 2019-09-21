namespace MyMusicStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelOrder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Firstname", c => c.String(nullable: false, maxLength: 160));
            AlterColumn("dbo.Orders", "LastName", c => c.String(nullable: false, maxLength: 160));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "LastName", c => c.String());
            AlterColumn("dbo.Orders", "Firstname", c => c.String());
        }
    }
}
