using AutoMapper;
using Project.Wta.Management.Cars.Domain.Commands.v1.CreateCars;
using Project.Wta.Management.Cars.Domain.Entities.v1;

namespace Domain.Commands.v1.CreateCars
{
    public class CreateCarCommandProfile : Profile
    {
        public CreateCarCommandProfile()
        {
            CreateMap<CreateCarCommand, CarEntity>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ForMember(dest => dest.CreateAt, opt => opt.MapFrom(src => DateTime.Now))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.Km, opt => opt.MapFrom(src => src.Km))
                .ForMember(dest => dest.LisensePlate, opt => opt.MapFrom(src => src.LisensePlate))
                .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                .ForMember(dest => dest.PersonId, opt => opt.MapFrom(src => src.PersonId));
        }
    }
}