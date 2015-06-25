using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Market.Domain.Entities;

namespace Market.Data.Configurations
{
    class PurchaseConfiguration : EntityTypeConfiguration<Purchase>
    {
        public PurchaseConfiguration()
        {
            ToTable("Purchases");
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).IsRequired().HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(255);
            Property(p => p.Price).IsRequired().HasColumnName("Price").HasColumnType("decimal");
            Property(p => p.Buyed).IsRequired().HasColumnName("Buyed").HasColumnType("bit");
            Property(p => p.BuyedTime).IsRequired().HasColumnName("BuyedTime");

            HasRequired(p=>p.Category).WithMany(c=>c.Purchases).HasForeignKey(p=>p.CategoryId).WillCascadeOnDelete(true);
        }
    }
}
