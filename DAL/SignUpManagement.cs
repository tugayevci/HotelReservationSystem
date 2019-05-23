using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SignUpManagement
    {
        DatabaseContext database;

        public SignUpManagement()
        {
            database = new DatabaseContext();
        }

        public bool CheckIfUserExist(AppUser appUser)
        {
            try
            {              
                return database.AppUsers.Where(x => x.UserName.Equals(appUser.UserName) || x.UserEmail.Equals(appUser.UserEmail)).Count() > 0 ? true : false;
            }
            catch
            {
                return true;
            }           
        }

        public bool AppUserAdd(AppUser appUser)
        {
            try
            {
                database.AppUsers.Add(appUser);
                database.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        

        //public int MusteriAraReturnID(Musteri musteri)
        //{
        //    Musteri result;

        //    try
        //    {
        //        result = database.Musteri.First(x => x.MusteriAd.Contains(musteri.MusteriAd));
        //    }
        //    catch
        //    {

        //        return 0;
        //    }


        //    int resultInt = result.MusteriID;
        //    return resultInt;
        //}


        


    }
}
