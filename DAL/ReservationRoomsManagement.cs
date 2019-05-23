using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservationRoomsManagement
    {
        DatabaseContext database;

        public ReservationRoomsManagement()
        {
            database = new DatabaseContext();
        }

        public bool AddReservation(ReservationRooms reservationRooms)
        {
            try
            {
                database.ReservationRooms.Add(reservationRooms);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
