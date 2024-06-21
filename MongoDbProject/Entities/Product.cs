using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDbProject.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
