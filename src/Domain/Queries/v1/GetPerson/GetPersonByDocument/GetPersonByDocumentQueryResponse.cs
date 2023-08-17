using System.Reflection.Metadata;
using Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByLicensePlate;

namespace Domain.Queries.v1.GetPerson.GetPersonByDocument
{
    public class GetPersonByDocumentQueryResponse
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Document { get; set; }
        public string? Phone { get; set; }
        public IEnumerable<GetCarByLicensePlateQueryResponse>? Cars { get; set; }

        public GetPersonByDocumentQueryResponse(Guid id, string? name, string? document, string? phone, IEnumerable<GetCarByLicensePlateQueryResponse>? cars)
        {
            Name = name;
            Document = document;
            Phone = phone;
            Cars = cars; 
            Id = id;
        }
    }
}