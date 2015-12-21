namespace RazorCars.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RazorCars.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RazorCars.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            if (!(context.Users.Any(u => u.UserName == "test@theironyard.com")))
            {
                var userStore = new UserStore<Employee>(context);
                var userManager = new UserManager<Employee>(userStore);
                var userToInsert = new Employee { Email = "test@theironyard.com", UserName = "test@theironyard.com", PhoneNumber = "0797697898" };
                userManager.Create(userToInsert, "Password@123");
            }

            context.SaveChanges();

            var store = new Store() { Name = "Store 2286" };
            var store2 = new Store() { Name = "Store 1144" };



            context.Stores.AddOrUpdate(x => x.Name, store, store2);

            var user = context.Users.Where(x => x.Email == "test@theironyard.com").FirstOrDefault();
            user.Store = store;

            context.Cars.AddOrUpdate(x => new { x.ModelYear, x.Manufacturer, x.CarModel },
                new Car { ModelYear = "2015", Manufacturer = "Ford", CarModel = "Explorer" }
                //ADD more cars here if you'd like
                );

           
            


        }
    }
}
