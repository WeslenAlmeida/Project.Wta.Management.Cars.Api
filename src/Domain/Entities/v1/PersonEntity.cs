using System.Reflection.Metadata;
using MongoDB.Bson.Serialization.Attributes;
using Project.Wta.Management.Cars.Domain.Entities.v1;

namespace Domain.Entities.v1
{
    public class PersonEntity
    {
        [BsonElement("id")]
        public Guid Id { get; set; }

         [BsonElement("createAt")]
        public DateTime CreateAt { get; set; } 

         [BsonElement("name")] 
        public string? Name { get; set; }

         [BsonElement("document")]
        public string? Document  { get; set; }

         [BsonElement("phone")]
        public string? Phone { get; set; }
    }
}