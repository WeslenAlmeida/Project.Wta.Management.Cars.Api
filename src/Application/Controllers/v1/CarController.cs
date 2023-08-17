using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByPersonDocument;

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

        [HttpGet("licence-plate")]
        public async Task<IActionResult> GetCarByLicensePlate([FromQuery]string LicensePlate)
        {
            return await GenerateHttpResponse(new GetCarByLicensePlateQuery(LicensePlate), HttpStatusCode.OK);
        }

         [HttpGet("person-document")]
        public async Task<IActionResult> GetCarByPersonId([FromQuery]string document)
        {
            return await GenerateHttpResponse(new GetCarByPersonDocumentQuery(document), HttpStatusCode.OK);
        }
    }
}