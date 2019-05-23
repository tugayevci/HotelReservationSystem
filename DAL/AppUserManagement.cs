using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppUserManagement
    {
        DatabaseContext database;

        public AppUserManagement()
        {
            database = new DatabaseContext();
        }

        public List<AppUser> GetAppUsers()
        {
            return database.AppUsers.ToList();
        }

        public bool DeleteAppUser(AppUser appUser)
        {
            try
            {
                database.AppUsers.Attach(appUser);
                database.AppUsers.Remove(appUser);
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
