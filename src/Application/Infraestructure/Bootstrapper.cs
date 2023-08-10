using System.Reflection;
using MediatR;
using Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars;
using Project.Wta.Management.Cars.Domain.Interface.v1.Repositories;
using Project.Wta.Management.Cars.Infrastructure.Data.v1.Mongo;

namespace Project.Wta.Management.Cars.Application.Infraestructure
{
    public class Bootstrapper
    {
        public Bootstrapper(IServiceCollection services)
        {
            InjectMediator(services);
            InjectScoped(services);
        }

        private static void InjectScoped(IServiceCollection services)
        {
            services.AddScoped<ICarRepository, CarRepository>();    
        }

        private static void InjectMediator(IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCarCommand).GetTypeInfo().Assembly);
        }
    }
}