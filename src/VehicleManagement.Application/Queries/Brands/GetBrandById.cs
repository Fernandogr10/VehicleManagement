using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Application.Common.Interfaces.Repositories;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Queries.Brands
{
    public static class GetBrandById
    {
        public record Query(Guid Id) : IRequest<Response>;

        public class Handler : IRequestHandler<Query, Response>
        {
            private readonly IBrandRepository _repository;

            public Handler(IBrandRepository repository)
            {
                _repository = repository;
            }
            
            public async Task<Response> Handle(Query request, CancellationToken cancellationToken)
            {
                var brand = await _repository.FindById(request.Id);

                return brand == null ? null : new Response(brand.Id, brand.Name);
            }
        }
        
        public record Response(Guid Id, string Name);
    }
}