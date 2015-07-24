using System.Data.Entity;
using Market.Data.Configurations;
using Market.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Market.Data.Contexts
{
   public class DomainDbContext : DbContext
    {
       public DomainDbContext() : base("name = DomainContext")
       {
           
       }

       public DbSet<User> Users { get; set; }
       public DbSet<Account> Accounts { get; set; } 
       public DbSet<Purchase> Purchases { get; set; }
       public DbSet<Category> Categories { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Configurations.Add(new UserConfiguration());
           modelBuilder.Configurations.Add(new AccountConfiguration());

           modelBuilder.Configurations.Add(new PurchaseConfiguration());
           modelBuilder.Configurations.Add(new CategoryConfiguration());

           modelBuilder.Ignore<IdentityUserClaim>();
           modelBuilder.Ignore<IdentityUserLogin>();
           modelBuilder.Ignore<IdentityUserRole>();
           modelBuilder.Ignore<IdentityRole>();

           base.OnModelCreating(modelBuilder);
       }
    }
}
