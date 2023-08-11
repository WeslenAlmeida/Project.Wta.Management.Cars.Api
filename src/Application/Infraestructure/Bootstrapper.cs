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
            InjectScoped(services);
            InjectMediator(services);
            InjectAutoMapper(services);
        }

        private static void InjectScoped(IServiceCollection services)
        {
            services.AddScoped(typeof(ICarRepository), typeof(CarRepository));    
        }

        private static void InjectMediator(IServiceCollection services)
        {
            services.AddMediatR(typeof(CreateCarCommand).GetTypeInfo().Assembly);
        }

        private static void InjectAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}