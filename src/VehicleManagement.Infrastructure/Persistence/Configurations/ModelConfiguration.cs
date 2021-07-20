using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Infrastructure.Persistence.Configurations
{
    public class ModelConfiguration : BaseEntityConfiguration<Model>
    {
        public override void Configure(EntityTypeBuilder<Model> builder)
        {
            base.Configure(builder);

            builder.Property(m => m.Name)
                .HasMaxLength(200)
                .IsRequired();
            
            builder.HasMany(m => m.Vehicles)
                .WithOne(v => v.Model)
                .HasForeignKey(v => v.ModelId);
        }
    }
}