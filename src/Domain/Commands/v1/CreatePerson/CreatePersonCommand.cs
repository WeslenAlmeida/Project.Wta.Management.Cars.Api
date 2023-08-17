using System.Reflection.Metadata;
using MediatR;

namespace Project.Wta.Management.Cars.Domain.Commands.v1.CreatePerson
{
    public class CreatePersonCommand : IRequest<Unit>
    {
        public string? Name { get; set; }
        public string? Document { get; set; }
        public string? Phone { get; set; }
    }
}