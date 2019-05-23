namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ReservationRooms", "Reservation_ID", "dbo.Reservations");
            DropForeignKey("dbo.ReservationRooms", "Room_ID", "dbo.Rooms");
            DropIndex("dbo.ReservationRooms", new[] { "Reservation_ID" });
            DropIndex("dbo.ReservationRooms", new[] { "Room_ID" });
            RenameColumn(table: "dbo.ReservationRooms", name: "Reservation_ID", newName: "ReservationID");
            RenameColumn(table: "dbo.ReservationRooms", name: "Room_ID", newName: "RoomID");
            AlterColumn("dbo.ReservationRooms", "ReservationID", c => c.Int(nullable: false));
            AlterColumn("dbo.ReservationRooms", "RoomID", c => c.Int(nullable: false));
            CreateIndex("dbo.ReservationRooms", "ReservationID");
            CreateIndex("dbo.ReservationRooms", "RoomID");
            AddForeignKey("dbo.ReservationRooms", "ReservationID", "dbo.Reservations", "ID", cascadeDelete: true);
            AddForeignKey("dbo.ReservationRooms", "RoomID", "dbo.Rooms", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationRooms", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.ReservationRooms", "ReservationID", "dbo.Reservations");
            DropIndex("dbo.ReservationRooms", new[] { "RoomID" });
            DropIndex("dbo.ReservationRooms", new[] { "ReservationID" });
            AlterColumn("dbo.ReservationRooms", "RoomID", c => c.Int());
            AlterColumn("dbo.ReservationRooms", "ReservationID", c => c.Int());
            RenameColumn(table: "dbo.ReservationRooms", name: "RoomID", newName: "Room_ID");
            RenameColumn(table: "dbo.ReservationRooms", name: "ReservationID", newName: "Reservation_ID");
            CreateIndex("dbo.ReservationRooms", "Room_ID");
            CreateIndex("dbo.ReservationRooms", "Reservation_ID");
            AddForeignKey("dbo.ReservationRooms", "Room_ID", "dbo.Rooms", "ID");
            AddForeignKey("dbo.ReservationRooms", "Reservation_ID", "dbo.Reservations", "ID");
        }
    }
}
