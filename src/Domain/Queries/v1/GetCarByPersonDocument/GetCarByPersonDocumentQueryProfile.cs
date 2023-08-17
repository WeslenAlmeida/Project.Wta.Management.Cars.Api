using AutoMapper;
using Project.Wta.Management.Cars.Domain.Entities.v1;

namespace Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByPersonDocument
{
    public class GetCarByPersonDocumentQueryProfile : Profile
    {
        public GetCarByPersonDocumentQueryProfile()
        {
            CreateMap<CarEntity, GetCarByPersonDocumentQueryResponse>()
                .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                .ForMember(dest => dest.LisensePlate, opt => opt.MapFrom(src => src.LisensePlate))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.Km, opt => opt.MapFrom(src => src.Km));
        }
    }
}