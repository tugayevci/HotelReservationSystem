using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SignInController
    {
        SignInManagement signInManagement;

        public SignInController()
        {
            signInManagement = new SignInManagement();
        }
        public bool UserSignInControll(AppUser appUser)
        {
            if (appUser.UserName.Length<5)
            {
                return false;
            }
            if (appUser.UserPassword.Length<8)
            {
                return false;
            }

            return signInManagement.CheckIfUserExist(appUser);

        }

        public AppUser AppUserGet(AppUser appUser)
        {
            appUser = signInManagement.GetAppUser(appUser);
            return appUser;
        }
    }
}
