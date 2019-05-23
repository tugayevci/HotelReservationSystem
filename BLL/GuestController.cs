using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GuestController
    {
        GuestManagement guestManagement;

        public GuestController()
        {
            guestManagement = new GuestManagement();
        }

        public bool GuestControll(Guest guest)
        {
            if (guest.FirstName.Length < 2)
                return false;
            if (guest.LastName.Length < 2)
                return false;
            if (guest.TcNO.Length != 11)
                return false;
            


            bool guestIsExist = guestManagement.CheckGuestExist(guest);

            if (guestIsExist)
            {
                return true;
            }
            else
            {
                return guestManagement.GuestAdd(guest);
            }

        }
    }
}
