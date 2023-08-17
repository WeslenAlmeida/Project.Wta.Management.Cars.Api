using AutoMapper;
using Project.Wta.Management.Cars.Domain.Entities.v1;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate;

namespace Domain.Queries.v1.GetPerson.GetPersonByDocument
{
    public class GetPersonByDocumentQueryProfile : Profile
    {
        public GetPersonByDocumentQueryProfile()
        {
             CreateMap<CarEntity, GetCarByLicensePlateQueryResponse>()
                .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Manufacturer))
                .ForMember(dest => dest.LisensePlate, opt => opt.MapFrom(src => src.LisensePlate))
                .ForMember(dest => dest.Model, opt => opt.MapFrom(src => src.Model))
                .ForMember(dest => dest.Km, opt => opt.MapFrom(src => src.Km));
        }
    }
}