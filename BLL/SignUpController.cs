using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class SignUpController
    {
        SignUpManagement signUpManagement;

        public SignUpController()
        {
            signUpManagement = new SignUpManagement();
        }
        public bool UserSignUpControll(AppUser appUser)
        {
            if (appUser.UserName.Length < 5)
            {
                return false;
            }
            if (appUser.UserPassword.Length < 8)
            {
                return false;
            }

            //try
            //{
            //    Regex rx = new Regex(
            //@"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
            //   bool emailCheck = rx.IsMatch(appUser.UserEmail);

            //    if (!emailCheck)
            //    {
            //        return false;
            //    }
            //}
            //catch (FormatException)
            //{
            //    return false;
            //}

            if (!UserSignUpEmailControll(appUser))
                return false;



            bool userIsExist = signUpManagement.CheckIfUserExist(appUser);

            if (userIsExist)
            {
                return false;
            }
            else
            {
                return signUpManagement.AppUserAdd(appUser);
            }

            
        }


        public bool UserSignUpEmailControll(AppUser appUser)
        {

            try
            {
                Regex rx = new Regex(
            @"^[-!#$%&'*+/0-9=?A-Z^_a-z{|}~](\.?[-!#$%&'*+/0-9=?A-Z^_a-z{|}~])*@[a-zA-Z](-?[a-zA-Z0-9])*(\.[a-zA-Z](-?[a-zA-Z0-9])*)+$");
                bool emailCheck = rx.IsMatch(appUser.UserEmail);

                if (!emailCheck)
                {
                    return false;
                }
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }
    }
}
