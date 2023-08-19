using AutoMapper;
using Domain.Interface.v1.Repositories;
using MediatR;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate;

namespace Domain.Queries.v1.GetPerson.GetPersonByDocument
{
    public class GetPersonByDocumentQueryHandler: IRequestHandler<GetPersonByDocumentQuery, GetPersonByDocumentQueryResponse>
    {
        private readonly ICarRepository _carRepository;
        private readonly IPersonRepository _personRepository;

        private readonly IMapper _mapper;
        public GetPersonByDocumentQueryHandler( IMapper mapper, ICarRepository carRepository, IPersonRepository personRepository )
        {
            _carRepository = carRepository;
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<GetPersonByDocumentQueryResponse> Handle(GetPersonByDocumentQuery request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetPersonByDocument(request.Document!);
            var cars = await _carRepository.GetCarByPersonDocument(person.Document!);

            return new GetPersonByDocumentQueryResponse(person.Name, person.Document, person.Phone,
                                                         _mapper.Map<IEnumerable<GetCarByLicensePlateQueryResponse>>(cars));
        }
    }
}