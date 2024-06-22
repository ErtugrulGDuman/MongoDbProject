using MongoDbProject.Dtos.ProductDtos;

namespace MongoDbProject.Services.ProductSevices
{
    public interface IProductService
    {
        Task<List<ResultProductDtos>> GetAllProductAsync();
        Task CreateProductAsync(CreateProductDtos createProductDtos);
        Task UpdateProductAsync(UpdateProductDtos updateProductDtos);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDtos> GetByIdProductAsync(string id);
    }
}
