using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Room : BaseEntity
    {

        public Room()
        {
            RoomPrice = 100;
            ExtraBedPriceRatio = 1.2m;
            WeekendPriceRatio = 1.3m;
            OneGuestInRoomPriceRatio = 0.7m;
        }

        public int RoomNo { get; set; }
        //[ForeignKey("Reservation")]

        ////public int ReservationID { get; set; }
        public decimal RoomPrice { get; set; }
        [NotMapped]
        public decimal ExtraBedPriceRatio { get; set; }
        [NotMapped]
        public decimal WeekendPriceRatio { get; set; }
        [NotMapped]
        public decimal OneGuestInRoomPriceRatio { get; set; }

        public virtual List<Reservation> Reservations { get; set; }

    }
}
