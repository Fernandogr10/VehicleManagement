using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Infrastructure.Persistence.Configurations
{
    public class AnnouncementConfiguration: BaseEntityConfiguration<Announcement>
    {
        public override void Configure(EntityTypeBuilder<Announcement> builder)
        {
            base.Configure(builder);

            builder.HasOne(a => a.Vehicle)
                .WithOne(v => v.Announcement)
                .HasForeignKey<Announcement>(a => a.VehicleId);
        }
    }
}