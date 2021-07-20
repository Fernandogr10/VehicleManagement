using System;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagement.Domain.Entities;
using VehicleManagement.Domain.Enums;

namespace VehicleManagement.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            if (!context.Announcements.Any())
            {
                var seedBrand = new Brand("Ford");
                var seedModel = new Model("Ka", seedBrand);
                seedBrand.AddModel(seedModel);

                var seedVehicle = new Vehicle(seedModel, 2005, "Blue", EFuelType.Alcohol, 10000, 8000, DateTime.Now);
                var seedAnnouncement = new Announcement(seedVehicle);
                seedVehicle.AnnounceVehicle(seedAnnouncement);
                
                context.Brands.Add(seedBrand);
                context.Models.Add(seedModel);
                context.Vehicles.Add(seedVehicle);
                context.Announcements.Add(seedAnnouncement);

                await context.SaveChangesAsync();
            }
        }
    }
}