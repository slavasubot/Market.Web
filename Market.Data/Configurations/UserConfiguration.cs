using System.Data.Entity.ModelConfiguration;
using Market.Domain.Entities;

namespace Market.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("AspNetUsers");
            HasKey(u => u.Id);
            Property(u => u.UserName).IsRequired().HasColumnName("UserName").HasColumnType("nvarchar").HasMaxLength(255);
        }
    }
}
