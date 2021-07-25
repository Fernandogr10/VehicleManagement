using System.Threading.Tasks;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Common.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> Get(string username, string password);
    }
}