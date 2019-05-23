using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class RoomGuests : BaseEntity
    {
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        [ForeignKey("Guest")]

        public int GuestID { get; set; }
        [ForeignKey("Reservation")]

        public int ReservationID { get; set; }

        public virtual Room Room { get; set; }
        public virtual Guest Guest { get; set; }
        public virtual Reservation Reservation { get; set; }

    }
}
