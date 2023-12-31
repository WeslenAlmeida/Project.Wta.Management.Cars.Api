using Project.Wta.Management.Cars.Domain.Entities.v1;

namespace Project.Wta.Management.Cars.Domain.Interface.v1.Repositories
{
    public interface ICarRepository
    {
        Task InsertCar(CarEntity car);
        Task<IEnumerable<CarEntity>> GetCarByPersonDocument(string document);
        Task<CarEntity> GetCarByLisensePlate(string lisensePlate);
    }
}