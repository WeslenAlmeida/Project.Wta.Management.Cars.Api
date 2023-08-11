using AutoMapper;
using MediatR;
using Project.Wta.Management.Cars.Domain.Entities.v1;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;

namespace Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, Unit>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public CreateCarCommandHandler( IMapper mapper, ICarRepository carRepository )
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var car = _mapper.Map<CarEntity>(request);  

            await _carRepository.InsertCar(car);

            return Unit.Value;
        }
    }
}