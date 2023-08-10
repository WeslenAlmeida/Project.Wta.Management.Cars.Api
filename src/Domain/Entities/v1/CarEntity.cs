using MongoDB.Bson.Serialization.Attributes;

namespace Project.Wta.Management.Cars.Domain.Entities.v1
{
    public class CarEntity 
    {
        [BsonElement("id")]
        public Guid Id { get; set; }

         [BsonElement("createAt")]
        public DateTime CreateAt { get; set; } = DateTime.Now; 

         [BsonElement("model")] 
        public string? Model { get; set; }

         [BsonElement("manufacturer")]
        public string? Manufacturer  { get; set; }

         [BsonElement("km")]
        public int Km { get; set; }

         [BsonElement("lisensePlate")]
        public string? LisensePlate { get; set; }

        [BsonElement("personId")]
        public Guid PersonId { get; set; }
    }
}