using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Commands.Brands
{
    public static class CreateBrand
    {
        public record Command(string Name) : IRequest<int>;
        
        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IBrandRepository _repository;

            public Handler(IBrandRepository repository)
            {
                _repository = repository;
            }
            public async Task<int> Handle(Command request, CancellationToken cancellationToken)
            {
                if (string.IsNullOrEmpty(request.Name))
                    return 0;
                
                return await _repository.Add(new Brand(request.Name));
            }
        }
    }
}