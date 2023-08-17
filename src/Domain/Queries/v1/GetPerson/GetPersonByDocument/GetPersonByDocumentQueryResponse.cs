using System.Reflection.Metadata;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate;

namespace Domain.Queries.v1.GetPerson.GetPersonByDocument
{
    public class GetPersonByDocumentQueryResponse
    {
        public string? Name { get; set; }
        public string? Document { get; set; }
        public string? Phone { get; set; }
        public IEnumerable<GetCarByLicensePlateQueryResponse>? Cars { get; set; }

        public GetPersonByDocumentQueryResponse(string? name, string? document, string? phone, IEnumerable<GetCarByLicensePlateQueryResponse>? cars)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Cars = cars; 
        }
    }
}