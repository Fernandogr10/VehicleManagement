using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Infrastructure.Persistence.Configurations
{
    public class VehicleConfiguration : BaseEntityConfiguration<Vehicle>
    {
        public override void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            base.Configure(builder);

            builder.Property(v => v.Color)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(v => v.Year)
                .IsRequired();
            
            builder.Property(v => v.FuelType)
                .HasConversion<string>()
                .IsRequired();
            
            builder.Property(v => v.PurchasePrice)
                .IsRequired();
            
            builder.Property(v => v.SalePrice)
                .IsRequired();
            
            builder.Property(v => v.SaleDate)
                .IsRequired(false);
        }
    }
}