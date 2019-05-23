using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservationController
    {
        ReservationManagement reservationManagement;

        public ReservationController()
        {
            reservationManagement = new ReservationManagement();
        }

        

        public bool ReservationDateController(Reservation reservation)
        {
            if (reservation.CheckInDate >= reservation.CheckOutDate)
            {
                return false;
            }

            return true;           
            
        }

        double roomCount = 1;

        public double RoomCountCalculate(Reservation reservation)
        {

            if (reservation.ExtraBed)
            {
                roomCount = Convert.ToDouble(reservation.GuestCount) / 3.0f;
                roomCount = Math.Ceiling(roomCount);
                return roomCount;
            }
            else
            {
                roomCount = Convert.ToDouble(reservation.GuestCount) / 2.0f;
                roomCount = Math.Ceiling(roomCount);
                return roomCount;
            }
        }

        public bool ReservationRoomCheck(Reservation reservation)
        {

            return false;
        }
         

        public decimal ReservationPriceCalculator(Reservation reservation)
        {
            Room room = new Room();

            int dayCount = reservation.CheckOutDate.Day - reservation.CheckInDate.Day;

            List<DateTime> reservationDates = new List<DateTime>();
            DateTime tempDate = reservation.CheckInDate;

            for (int i = 0; i < dayCount; i++)
            {
                reservationDates.Add(tempDate);
                tempDate = tempDate.AddDays(1);
            }

            // database management üzerinden gidip. Room tablosundan Price alıp decimal a atıcaz.
            //şimdilik dafault value kullanıyorum

            decimal price = room.RoomPrice;

            decimal totalPrice = 0;

            int guestCount = reservation.GuestCount;

            foreach (DateTime item in reservationDates)
            {
                guestCount = reservation.GuestCount;
                DayOfWeek dayOfWeek = item.DayOfWeek;

                while (guestCount>0)
                {
                    if ((dayOfWeek == DayOfWeek.Saturday) || (dayOfWeek == DayOfWeek.Sunday))
                    {
                        if (guestCount==1)
                        {
                            totalPrice += price * room.OneGuestInRoomPriceRatio * room.WeekendPriceRatio;
                            guestCount -= 1;
                        }

                        if (reservation.ExtraBed)
                        {

                            if (guestCount >= 3)
                            {
                                totalPrice += price * room.ExtraBedPriceRatio * room.WeekendPriceRatio;
                                guestCount -= 3;
                            }
                            else if (guestCount == 2)
                            {
                                totalPrice += price*room.WeekendPriceRatio;
                                guestCount -= 2;
                            }
                        }
                        else
                        {
                            if (guestCount >= 2)
                            {
                                totalPrice += price * room.WeekendPriceRatio;
                                guestCount -= 2;
                            }

                        }
                    }
                    else
                    {

                        if (guestCount == 1)
                        {
                            totalPrice += price * room.OneGuestInRoomPriceRatio;
                            guestCount -= 1;
                        }

                        if (reservation.ExtraBed)
                        {
                            if (guestCount >= 3)
                            {
                                totalPrice += price * room.ExtraBedPriceRatio;
                                guestCount -= 3;
                            }
                            else if (guestCount==2)
                            {
                                totalPrice += price;
                                guestCount -= 2;
                            }
                           
                        }
                        else
                        {
                            if (guestCount >= 2)
                            {
                                totalPrice += price;
                                guestCount -= 2;
                            }
                        }
                    }
                }                        

            }

            return totalPrice*reservation.ReservationTypePriceRatio;

        }

        public int ReservationIdGet(Reservation reservation)
        {
            return reservationManagement.ReservationIdGet(reservation);
        }

        public bool AddReservationController(Reservation reservation)
        {
            //Controlleri ekliycez!!!
            return reservationManagement.AddReservation(reservation);
        }

        public List<ViewModelReservation> GetReservations()
        {
            return reservationManagement.GetReservations();
        }
        public bool DeleteReservation(Reservation reservation)
        {
            return reservationManagement.DeleteReservation(reservation);
        }

    }
}
