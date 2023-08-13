using MediatR;

namespace Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate
{
    public class GetCarByLicensePlateQuery : IRequest<GetCarByLicensePlateQueryResponse>
    {
        public string? LicensePlate { get; set; }

        public GetCarByLicensePlateQuery(string lisensePlate)
        {
            LicensePlate = lisensePlate;    
        }
    }
}