using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using VehicleManagement.Application.Common.Interfaces;
using VehicleManagement.Domain.Entities;

namespace VehicleManagement.Application.Queries.Brands
{
    public static class GetAllBrands
    {
        public record Query() : IRequest<List<Response>>;
        
        public class Handler : IRequestHandler<Query, List<Response>>
        {
            private readonly IBrandRepository _repository;

            public Handler(IBrandRepository repository)
            {
                _repository = repository;
            }
            
            public async Task<List<Response>> Handle(Query request, CancellationToken cancellationToken)
            {
                var brands = await _repository.FindAll();
                var responses = new List<Response>();
                
                foreach (var item in brands)
                {
                    responses.Add(new Response(item.Id, item.Name));
                }

                return responses;
            }
        }

        public record Response(Guid Id, string Name);
    }
}