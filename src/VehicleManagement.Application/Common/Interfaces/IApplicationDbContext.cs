using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Announcement> Announcements { get; set; }

        DbSet<Brand> Brands { get; set; }
        
        DbSet<Model> Models { get; set; }
        
        DbSet<Vehicle> Vehicles { get; set; }
    }
}