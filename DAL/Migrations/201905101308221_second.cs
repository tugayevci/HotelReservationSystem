namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Guests", "RoomID", "dbo.Rooms");
            DropIndex("dbo.Guests", new[] { "RoomID" });
            DropColumn("dbo.Guests", "RoomID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Guests", "RoomID", c => c.Int(nullable: false));
            CreateIndex("dbo.Guests", "RoomID");
            AddForeignKey("dbo.Guests", "RoomID", "dbo.Rooms", "ID", cascadeDelete: true);
        }
    }
}
