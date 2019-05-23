using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SignInManagement
    {

        DatabaseContext database;

        public SignInManagement()
        {
            database = new DatabaseContext();
        }

        public bool CheckIfUserExist(AppUser appUser)
        {
            try
            {               
                return database.AppUsers.Where(x => x.UserName.Equals(appUser.UserName) && x.UserPassword.Equals(appUser.UserPassword)).Count() > 0 ? true:false ;
            }
            catch
            {

                return false;
            }          
        }

        public AppUser GetAppUser(AppUser appUser)
        {
            appUser = database.AppUsers.FirstOrDefault(x => x.UserName.Equals(appUser.UserName) || x.UserEmail.Equals(appUser.UserEmail));
            return appUser;
        }
    }
}
