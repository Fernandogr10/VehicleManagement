using System.Threading.Tasks;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Application.Common.Interfaces.Repositories;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Infrastructure.Persistence.Repositories
{
    public class BrandRepository : Repository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext dbContext) : base(dbContext) { }
        
        public async Task<Brand> AddModelInBrand(Brand brand, Model model)
        {
            brand.AddModel(model);
            await Context.SaveChangesAsync();

            return brand;
        }
    }
}