using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ReservationRooms : BaseEntity
    {
        

        [ForeignKey("Reservation")]
        public int ReservationID { get; set; }
        [ForeignKey("Room")]
        public int RoomID { get; set; }
        
        public virtual Reservation Reservation { get; set; }
        public virtual Room Room { get; set; }

        [NotMapped]
        public Reservation ReservationTemp { get; set; }
        [NotMapped]
        public Room RoomTemp { get; set; }

    }
}
