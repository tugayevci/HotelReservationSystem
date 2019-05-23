using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservationRoomsController
    {
        ReservationRoomsManagement reservationRoomsManagement;

        public ReservationRoomsController()
        {
            reservationRoomsManagement = new ReservationRoomsManagement();
        }

        public bool AddReservationControll(ReservationRooms reservationRooms)
        {
            return reservationRoomsManagement.AddReservation(reservationRooms);
        }

    }
}
