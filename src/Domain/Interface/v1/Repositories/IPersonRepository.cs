using Domain.Entities.v1;

namespace Domain.Interface.v1.Repositories
{
    public interface IPersonRepository
    {
        
        Task InsertPerson(PersonEntity car);
        Task<PersonEntity> GetPersonByDocument(string document);
    }
}