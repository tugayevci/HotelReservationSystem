using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomManagement
    {
        DatabaseContext database;

        public RoomManagement()
        {
            database = new DatabaseContext();
        }

        public bool GetRoomAvailability(ReservationRooms reservationRooms)
        {
            ReservationRooms result = null;
            try
            {
                result = database.ReservationRooms.Where(x => x.RoomID.Equals(reservationRooms.Room.ID)).OrderByDescending(o=>o.ID).FirstOrDefault();
            }
            catch
            {


            }

            if (result is null)
            {
                return true;
            }
            else
            {               
                TempDates result2 = database.Reservations.Where(x => x.ID.Equals(result.ReservationID)).Select(x => new TempDates
                {
                    ID = x.ID,
                    tempCheckIn = x.CheckInDate,
                    tempCheckOut = x.CheckOutDate
                }).OrderByDescending(x=> x.ID).FirstOrDefault();

                DateTime tempCheckInDateTime = result2.tempCheckIn;
                DateTime tempCheckOutDateTime = result2.tempCheckOut;

                if ((reservationRooms.Reservation.CheckInDate< result2.tempCheckIn && reservationRooms.Reservation.CheckOutDate<result2.tempCheckOut) || (reservationRooms.Reservation.CheckInDate>result2.tempCheckOut && reservationRooms.Reservation.CheckOutDate>result2.tempCheckOut))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }         
        }

        private class TempDates
        {
            public int ID { get; set; }
            public DateTime tempCheckIn { get; set; }
            public DateTime tempCheckOut { get; set; }

        }

        public bool RoomAdd(Room room)
        {
            try
            {
                database.Rooms.Add(room);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetRoom(Room room)
        {
            return database.Rooms.Where(x => x.RoomNo.Equals(room.RoomNo)).Select(x => x.ID).First();
        }

        public List<int> GetRooms()
        {
            List<int> roomsNo;

            roomsNo = database.Rooms.Select(x => x.RoomNo).ToList();

            return roomsNo;
        }
    }
}
