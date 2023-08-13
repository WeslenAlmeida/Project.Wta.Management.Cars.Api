using AutoMapper;
using MediatR;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;

namespace Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate
{
    public class GetCarByLicensePlateQueryHandler: IRequestHandler<GetCarByLicensePlateQuery, GetCarByLicensePlateQueryResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public GetCarByLicensePlateQueryHandler( IMapper mapper, ICarRepository carRepository )
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<GetCarByLicensePlateQueryResponse> Handle(GetCarByLicensePlateQuery request, CancellationToken cancellationToken)
        {
            var response = await _carRepository.GetCarByLisensePlate(request.LicensePlate!);

            return _mapper.Map<GetCarByLicensePlateQueryResponse>(response);
        }
    }
}