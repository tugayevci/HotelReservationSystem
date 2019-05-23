namespace DAL.Migrations
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DatabaseContext>
    {
        
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(DAL.DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.  

            if (context.AppUsers.Count()==0)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = "admin",
                    UserPassword = "12345678",
                    UserRole = 1,
                    UserEmail ="admin@admin.com"                
                };
                context.AppUsers.Add(appUser);
                context.SaveChanges();
            }

            if (context.Rooms.Count()==0)
            {

                for (int i = 101; i <= 120; i++)
                {
                    Room room = new Room()
                    {
                        RoomNo = i,
                    };
                    context.Rooms.Add(room);
                }

                context.SaveChanges();
            }
        }
    }
}
