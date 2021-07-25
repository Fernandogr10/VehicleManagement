using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Application.Common.Interfaces.Repositories;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Commands.Brands
{
    public static class UpdateBrand
    {
        public record Command(Guid Id, string Name) : IRequest<int>;
        
        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IBrandRepository _repository;

            public Handler(IBrandRepository repository)
            {
                _repository = repository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var (guid, name) = request;
                
                if (string.IsNullOrEmpty(name))
                    return 0;
                
                var brand = await _repository.FindById(guid);

                brand.Name = name;
                
                return await _repository.Update(brand);
            }
        }
    }
}