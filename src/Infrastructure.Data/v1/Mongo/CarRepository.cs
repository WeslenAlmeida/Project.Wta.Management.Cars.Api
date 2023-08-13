using System.Linq;
using MongoDB.Driver;
using Project.Wta.Management.Cars.CrossCutting.Configuration;
using Project.Wta.Management.Cars.Domain.Entities.v1;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;

namespace Project.Wta.Management.Cars.Infrastructure.Data.v1.Mongo
{
    public class CarRepository : ICarRepository
    {
        private readonly IMongoCollection<CarEntity> _carCollection;

        public CarRepository()
        {
            var mongoClient = new MongoClient(AppSettings.MongoSettings.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(AppSettings.MongoSettings.DatabaseName);
            _carCollection = mongoDatabase.GetCollection<CarEntity>("cars");
        }

        public async Task<CarEntity> GetCarByLisensePlate(string lisensePlate)
        {
            var response = await _carCollection.FindAsync(x => x.LisensePlate == lisensePlate);
            return response.FirstOrDefault();   
        }

        public async Task<IEnumerable<CarEntity>> GetCarByPersonId(Guid personId)
        {
            var response = await _carCollection.FindAsync(x => x.PersonId == personId);
            return response.ToEnumerable();  
        }
        
        public async Task InsertCar(CarEntity car) =>
            await _carCollection.InsertOneAsync(car);
    }
}