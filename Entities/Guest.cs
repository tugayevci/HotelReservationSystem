using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Guest : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNO { get; set; }

        //[ForeignKey("AppUser")]
        //public int AppUserID { get; set; }

        //[ForeignKey("Room")]
        //public int RoomID { get; set; }
        //public virtual Room Room { get; set; }
        //public virtual AppUser AppUser { get; set; }
    }
}
