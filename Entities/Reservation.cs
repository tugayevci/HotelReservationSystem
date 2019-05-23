using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reservation : BaseEntity
    {



        [ForeignKey("AppUser")]
        public int AppUserID { get; set; }

        //[ForeignKey("Rooms")]
        //public int RoomID { get; set; }
        public int GuestCount { get; set; }
        public decimal TotalPrice { get; set; }
        public byte ReservationType
        {
            set
            {
                switch (value)
                {
                    case 0:
                        ReservationTypePriceRatio = 1;
                        break;
                    case 1:
                        ReservationTypePriceRatio = 1.25m;
                        break;
                    case 2:
                        ReservationTypePriceRatio = 1.50m;
                        break;
                    default:
                        break;
                }
            }
        }
        [NotMapped]
        public decimal ReservationTypePriceRatio { get; set; }
        public bool ExtraBed { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual List<Room> Rooms { get; set; }



    }

    public class ViewModelReservation
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int GuestCount { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
