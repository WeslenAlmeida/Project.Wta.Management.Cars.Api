using MediatR;
using Project.Wta.Management.Cars.Domain.Entities.v1;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;

namespace Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Unit>
    {
        private readonly ICarRepository _carRepository;   
        public CreateCarCommandHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public async Task<Unit> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _carRepository.InsertCar(new CarEntity());

            return Unit.Value;
        }
    }
}