using Market.Data.Contexts;
using Market.Domain.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Market.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
   

    internal sealed class Configuration : DbMigrationsConfiguration<AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuthContext context)
        {
            var manager = new UserManager<User>(new UserStore<User>(new AuthContext()));

            var user = new User
            {
                UserName = "Slava",
                Email = "slavasubot@gmail.com",
                EmailConfirmed = true,
                JoinDate = DateTime.Now.AddYears(-1)
            };

            manager.Create(user, "qwerty12345");
        }
    }
}
