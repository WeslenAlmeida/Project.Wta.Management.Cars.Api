using MediatR;

namespace Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars
{
    public class CreateCarCommand : IRequest<Unit>
    {
        public string? Model { get; set; }
        public string? Manufacturer  { get; set; }
        public int Km { get; set; }
        public string? LisensePlate { get; set; }
    }
}