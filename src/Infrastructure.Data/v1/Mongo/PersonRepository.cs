using Domain.Entities.v1;
using Domain.Interface.v1.Repositories;
using MongoDB.Driver;
using Project.Wta.Management.Cars.CrossCutting.Configuration;

namespace Infrastructure.Data.v1.Mongo
{
    public class PersonRepository: IPersonRepository
    {
        private readonly IMongoCollection<PersonEntity> _personCollection;

        public PersonRepository()
        {
            var mongoClient = new MongoClient(AppSettings.MongoSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(AppSettings.MongoSettings.DatabaseName);
            _personCollection = mongoDatabase.GetCollection<PersonEntity>("person");
        }

        public async Task<PersonEntity> GetPersonByDocument(string document)
        {
            var response = await _personCollection.FindAsync(x => x.Document == document);  
            return response.FirstOrDefault();  
        }

        public async Task InsertPerson(PersonEntity car) =>
            await _personCollection.InsertOneAsync(car);
        
    }
}