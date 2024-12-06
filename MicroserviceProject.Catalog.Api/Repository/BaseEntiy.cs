using MongoDB.Bson.Serialization.Attributes;

namespace MicroserviceProject.Catalog.Api.Repository
{
    public class BaseEntiy
    {
        [BsonElement("_id")]
        public Guid Id { get; set; }
    }
}
