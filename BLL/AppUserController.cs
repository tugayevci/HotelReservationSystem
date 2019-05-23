using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AppUserController
    {
        AppUserManagement appUserManagement;

        public AppUserController()
        {
            appUserManagement = new AppUserManagement();
        }

        public List<AppUser> GetAppUsers()
        {
            return appUserManagement.GetAppUsers();
        }

        public bool DeleteAppUser(AppUser appUser)
        {
            return appUserManagement.DeleteAppUser(appUser);
        }
    }
}
