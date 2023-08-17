using AutoMapper;
using MediatR;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;

namespace Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByPersonDocument
{
    public class GetCarByPersonDocumentQueryHandler: IRequestHandler<GetCarByPersonDocumentQuery, IEnumerable<GetCarByPersonDocumentQueryResponse>>
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;
        public GetCarByPersonDocumentQueryHandler( IMapper mapper, ICarRepository carRepository )
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<GetCarByPersonDocumentQueryResponse>> Handle(GetCarByPersonDocumentQuery request, CancellationToken cancellationToken)
        {
            var response = await _carRepository.GetCarByPersonDocument(request.Document!);

            return _mapper.Map<IEnumerable<GetCarByPersonDocumentQueryResponse>>(response);
        }
    }
}