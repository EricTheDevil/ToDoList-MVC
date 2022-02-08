namespace Todo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Todo.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Todo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Todo.Models.ApplicationDbContext";
        }

        protected override void Seed(Todo.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            AddUsers(context);
        }
        void AddUsers(Todo.Models.ApplicationDbContext context)
        {
            var user = new ApplicationUser { UserName = "user@gmail.com" };
            var um = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context ));
            um.Create(user, "password");
        }
    }
}
