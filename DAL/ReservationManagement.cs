using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservationManagement
    {
        DatabaseContext database;

        public ReservationManagement()
        {
            database = new DatabaseContext();
        }



        public int ReservationIdGet(Reservation reservation)
        {
            int id = 0;
            try
            {

                id = reservation.ID;
            }
            catch
            {

            }

            return id;
        }

        public bool ReservationRoomCheck(Reservation reservation)
        {
            List<bool> boolList = new List<bool>();

            try
            {
                Reservation check = database.Reservations.FirstOrDefault(x => x.CheckInDate.Equals(reservation.CheckInDate) && x.CheckOutDate.Equals(reservation.CheckOutDate));
            }
            catch
            {

            }

            return false;
        }

        public bool AddReservation(Reservation reservation)
        {
            try
            {
                database.Reservations.Add(reservation);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteReservation(Reservation reservation)
        {
            try
            {
                database.Reservations.Attach(reservation);
                database.Reservations.Remove(reservation);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ViewModelReservation> GetReservations()
        {
            //var RESULT = database.Reservations.Select(x => new Reservation
            //{
            //    x.ID
            //}).ToList();
            var result = new List<ViewModelReservation>();

            var tempResult = database.Reservations.Select(i => new ViewModelReservation
            {
                ID = i.ID,
                Username = i.AppUser.UserName,
                GuestCount = i.GuestCount,
                TotalPrice = i.TotalPrice,
                CheckInDate = i.CheckInDate,
                CheckOutDate = i.CheckOutDate,
                CreatedAt = i.CreatedAt
            }).ToList();
            result = tempResult;
            return result;
        }

    }
}
