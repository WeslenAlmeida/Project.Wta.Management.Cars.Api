using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Domain.Queries.v1.GetPerson.GetPersonByDocument;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Wta.Management.Cars.Api.Controllers;
using Project.Wta.Management.Cars.Domain.Commands.v1.CreatePerson;

namespace Application.Controllers.v1
{
    [Route("api/v1/person")]
    public class PersonController : ApiBaseController
    {
        
        public PersonController(IMediator mediator) : base(mediator)
        {
        }
        
        [HttpPost]
        public async Task<IActionResult> CreatePersonAsync([FromBody]CreatePersonCommand request)
        {
            return await GenerateHttpResponse(request, HttpStatusCode.Created);
        }

        [HttpGet("document")]
        public async Task<IActionResult> GetPersonByDocument([FromQuery]string document)
        {
            return await GenerateHttpResponse(new GetPersonByDocumentQuery(document), HttpStatusCode.OK);
        }
    }
}