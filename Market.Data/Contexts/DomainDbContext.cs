using System.Data.Entity;
using Market.Data.Configurations;
using Market.Domain.Entities;

namespace Market.Data.Contexts
{
   public class DomainDbContext : DbContext
    {
       public DomainDbContext() : base("name = DomainContext")
       {
           
       }

       public DbSet<Purchase> Purchases { get; set; }
       public DbSet<Category> Categories { get; set; }

       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Configurations.Add(new PurchaseConfiguration());
           modelBuilder.Configurations.Add(new CategoryConfiguration());
           base.OnModelCreating(modelBuilder);
       }
    }
}
