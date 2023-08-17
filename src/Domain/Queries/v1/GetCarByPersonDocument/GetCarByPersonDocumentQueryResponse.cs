namespace Project.Wta.Management.Cars.Domain.Queries.v1.GetCarByPersonDocument
{
    public class GetCarByPersonDocumentQueryResponse
    {
        public string? Model { get; set; }
        public string? Manufacturer  { get; set; }
        public int Km { get; set; }
        public string? LisensePlate { get; set; }
    }
}