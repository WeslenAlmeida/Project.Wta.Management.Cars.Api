using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars;

namespace Project.Wta.Management.Cars.Api.Controllers.v1
{
    [Route("api/v1/car")]
    [ApiController]
    public class CarController : ApiBaseController
    {
        
        public CarController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCar([FromBody]CreateCarCommand request)
        {
            return await GenerateHttpResponse(request, HttpStatusCode.Created);
        }
    }
}