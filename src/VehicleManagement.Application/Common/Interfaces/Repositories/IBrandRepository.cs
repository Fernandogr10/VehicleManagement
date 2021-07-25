using System.Threading.Tasks;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Common.Interfaces.Repositories
{
    public interface IBrandRepository : IRepository<Brand>
    {
        Task<Brand> AddModelInBrand(Brand brand, Model model);
    }
}