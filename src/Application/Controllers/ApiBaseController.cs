using System.Net;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Project.Wta.Management.Cars.Api.Controllers
{
    public abstract class ApiBaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApiBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        protected async Task<IActionResult> GenerateHttpResponse(object request, HttpStatusCode statusCode)
        {
            try
            {
               var response = await _mediator.Send(request);
               return StatusCode((int)statusCode, response);
               
            }catch(Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}