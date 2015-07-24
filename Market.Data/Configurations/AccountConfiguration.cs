using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Market.Domain.Entities;

namespace Market.Data.Configurations
{
   public class AccountConfiguration : EntityTypeConfiguration<Account>
   {
       public AccountConfiguration()
       {
           ToTable("Accounts");
           HasKey(a => a.Id);
           Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
           Property(a => a.Descriptions).IsOptional().HasColumnName("Descriptions").HasColumnType("nvarchar").HasMaxLength(255);
           Property(a => a.CreatedAt).IsRequired().HasColumnName("CreatedAt");
           Property(a => a.UpdatedAt).IsRequired().HasColumnName("UpdatedAt");

           HasRequired(a=>a.User).WithMany(u=>u.Accounts).HasForeignKey(a=>a.UserId).WillCascadeOnDelete(true);
       }
   }
}
