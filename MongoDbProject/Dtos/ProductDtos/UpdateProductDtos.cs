using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDbProject.Dtos.ProductDtos
{
    public class UpdateProductDtos
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
