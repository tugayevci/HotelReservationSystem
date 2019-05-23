using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [NotMapped]
    public static class HelperStaticClass
    {
        public static Dictionary<int, int> roomGuestDictionary { get; set; }
        public static List<Guest> guests { get; set; }
        public static Dictionary<Guest, int> guestsDictionery { get; set; }
        public static Reservation reservationStatic { get; set; }
        public static AppUser appUserStatic { get; set; }

    }
}
