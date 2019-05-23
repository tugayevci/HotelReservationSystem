namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.RoomGuests", "RoomID");
            CreateIndex("dbo.RoomGuests", "GuestID");
            CreateIndex("dbo.RoomGuests", "ReservationID");
            AddForeignKey("dbo.RoomGuests", "GuestID", "dbo.Guests", "ID", cascadeDelete: true);
            AddForeignKey("dbo.RoomGuests", "ReservationID", "dbo.Reservations", "ID", cascadeDelete: true);
            AddForeignKey("dbo.RoomGuests", "RoomID", "dbo.Rooms", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RoomGuests", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.RoomGuests", "ReservationID", "dbo.Reservations");
            DropForeignKey("dbo.RoomGuests", "GuestID", "dbo.Guests");
            DropIndex("dbo.RoomGuests", new[] { "ReservationID" });
            DropIndex("dbo.RoomGuests", new[] { "GuestID" });
            DropIndex("dbo.RoomGuests", new[] { "RoomID" });
        }
    }
}
