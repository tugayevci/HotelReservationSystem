namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        UserPassword = c.String(nullable: false),
                        UserEmail = c.String(),
                        UserRole = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AppUserID = c.Int(nullable: false),
                        GuestCount = c.Int(nullable: false),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExtraBed = c.Boolean(nullable: false),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AppUsers", t => t.AppUserID, cascadeDelete: true)
                .Index(t => t.AppUserID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomNo = c.Int(nullable: false),
                        RoomPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        TcNO = c.String(),
                        RoomID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.RoomID, cascadeDelete: true)
                .Index(t => t.RoomID);
            
            CreateTable(
                "dbo.ReservationRooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActived = c.Boolean(nullable: false),
                        Reservation_ID = c.Int(),
                        Room_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID)
                .ForeignKey("dbo.Rooms", t => t.Room_ID)
                .Index(t => t.Reservation_ID)
                .Index(t => t.Room_ID);
            
            CreateTable(
                "dbo.RoomGuests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        GuestID = c.Int(nullable: false),
                        ReservationID = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsActived = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RoomReservations",
                c => new
                    {
                        Room_ID = c.Int(nullable: false),
                        Reservation_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Room_ID, t.Reservation_ID })
                .ForeignKey("dbo.Rooms", t => t.Room_ID, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID, cascadeDelete: true)
                .Index(t => t.Room_ID)
                .Index(t => t.Reservation_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationRooms", "Room_ID", "dbo.Rooms");
            DropForeignKey("dbo.ReservationRooms", "Reservation_ID", "dbo.Reservations");
            DropForeignKey("dbo.Guests", "RoomID", "dbo.Rooms");
            DropForeignKey("dbo.RoomReservations", "Reservation_ID", "dbo.Reservations");
            DropForeignKey("dbo.RoomReservations", "Room_ID", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "AppUserID", "dbo.AppUsers");
            DropIndex("dbo.RoomReservations", new[] { "Reservation_ID" });
            DropIndex("dbo.RoomReservations", new[] { "Room_ID" });
            DropIndex("dbo.ReservationRooms", new[] { "Room_ID" });
            DropIndex("dbo.ReservationRooms", new[] { "Reservation_ID" });
            DropIndex("dbo.Guests", new[] { "RoomID" });
            DropIndex("dbo.Reservations", new[] { "AppUserID" });
            DropTable("dbo.RoomReservations");
            DropTable("dbo.RoomGuests");
            DropTable("dbo.ReservationRooms");
            DropTable("dbo.Guests");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.AppUsers");
        }
    }
}
