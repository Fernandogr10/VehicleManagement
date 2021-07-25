using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VehicleManagement.Application.Common.Interfaces.Repositories;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Infrastructure.Persistence.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public async Task<User> Get(string username, string password)
        {
            return await DbSet.FirstOrDefaultAsync(u => string.Equals(u.Username, username, StringComparison.CurrentCultureIgnoreCase) && u.Password == password);
        }
    }
}