using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AppUser : BaseEntity
    {

        public AppUser()
        {
            UserRole = 0;
        }

        [Required]

        public string UserName { get; set; }
        [Required]

        public string UserPassword { get; set; }
        public string UserEmail { get; set; }

        //[ForeignKey("Reservations")]
        //public int? ReservationID { get; set; }

        [Required]
        //[Column(TypeName = "smallint")]
        public int UserRole { get; set; }

        public virtual List<Reservation> Reservations { get; set; }
        //public virtual List<Guest> Guests { get; set; }
    }
}
