using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration: BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(u => u.Username)
                .HasMaxLength(300)
                .IsRequired();

            builder.Property(u => u.Password)
                .HasMaxLength(500)
                .IsRequired();
            
            builder.Property(u => u.Role)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}