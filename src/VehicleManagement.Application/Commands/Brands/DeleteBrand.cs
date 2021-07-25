using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Application.Common.Interfaces.Repositories;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Commands.Brands
{
    public static class DeleteBrand
    {
        public record Command(Guid Id) : IRequest<int>;
        
        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IBrandRepository _repository;

            public Handler(IBrandRepository repository)
            {
                _repository = repository;
            }

            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                var brand = await _repository.FindById(request.Id);

                if (brand is null)
                    return 0;
                
                await _repository.Remove(brand);
                return 1;
            }
        }
    }
}