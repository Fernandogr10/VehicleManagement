using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using VehicleManagement.Application.Commands.Brands;
using VehicleManagement.Application.Queries.Brands;

namespace VehicleManagement.Api.Controllers
{
    [Route("Brands")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var query = new GetAllBrands.Query();
            var result = await _mediator.Send(query);

            return Ok(result);
        }
        
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetBrandById(Guid id)
        {
            var result = await _mediator.Send(new GetBrandById.Query(id));
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand([FromBody] CreateBrand.Command command)
        {
            var result = await _mediator.Send(command);
            return result > 0 ? Ok(result) : Problem(statusCode: 400);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateBrand(Guid id, [FromBody] UpdateBrand.Command command)
        {
            var result = await _mediator.Send(new UpdateBrand.Command(id, command.Name));
            return result > 0 ? Ok(result) : Problem(statusCode: 400);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            var result = await _mediator.Send(new DeleteBrand.Command(id));
            return result > 0 ? Ok(result) : Problem(statusCode: 400);
        }
    }
}