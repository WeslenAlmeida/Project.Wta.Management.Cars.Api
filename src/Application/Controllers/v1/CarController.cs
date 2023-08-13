using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate;

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
        public async Task<IActionResult> CreateCarAsync([FromBody]CreateCarCommand request)
        {
            return await GenerateHttpResponse(request, HttpStatusCode.Created);
        }

        [HttpGet]
        public async Task<IActionResult> GetCarByLicensePlate([FromQuery]string LicensePlate)
        {
            return await GenerateHttpResponse(new GetCarByLicensePlateQuery(LicensePlate), HttpStatusCode.OK);
        }
    }
}