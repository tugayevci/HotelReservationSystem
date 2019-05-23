using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GuestManagement
    {
        DatabaseContext database;

        public GuestManagement()
        {
            database = new DatabaseContext();
        }

        public bool CheckGuestExist(Guest guest)
        {
            Guest tempGuest = null;

            try
            {
                tempGuest = database.Guests.First(x => x.TcNO.Equals(guest.TcNO));
            }
            catch
            {
                
            }

            if (tempGuest is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool GuestAdd(Guest guest)
        {
            try
            {
                database.Guests.Add(guest);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
