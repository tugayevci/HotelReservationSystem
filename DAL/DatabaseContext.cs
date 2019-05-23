using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=localConnectionString")
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<ReservationRooms> ReservationRooms { get; set; }
        public DbSet<RoomGuests> RoomGuests { get; set; }


    }
}
