using AutoMapper;
using Domain.Entities.v1;
using Domain.Interface.v1.Repositories;
using MediatR;

namespace Project.Wta.Management.Cars.Domain.Commands.v1.CreatePerson
{
    public class CreatePersonCommandHandler: IRequestHandler<CreatePersonCommand, Unit>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public CreatePersonCommandHandler( IMapper mapper, IPersonRepository personRepository )
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = _mapper.Map<PersonEntity>(request);  

            await _personRepository.InsertPerson(person);

            return Unit.Value;
        }
    }
}