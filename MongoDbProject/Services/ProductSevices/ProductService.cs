using AutoMapper;
using MongoDB.Driver;
using MongoDbProject.Dtos.ProductDtos;
using MongoDbProject.Entities;

namespace MongoDbProject.Services.ProductSevices
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMongoCollection<Product> productCollection, IMapper mapper)
        {
            _productCollection = productCollection;
            _mapper = mapper;
        }

        public async Task CreateProductAsync(CreateProductDtos createProductDtos)
        {
            var value = _mapper.Map<Product>(createProductDtos);
            await _productCollection.InsertOneAsync(value);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductId == id);
        }

        public async Task<List<ResultProductDtos>> GetAllProductAsync()
        {
            var values = await _productCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultProductDtos>>(values);
        }

        public async Task<GetByIdProductDtos> GetByIdProductAsync(string id)
        {
            var values = await _productCollection.Find<Product>(x => x.ProductId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdProductDtos>(values);
        }

        public async Task UpdateProductAsync(UpdateProductDtos updateProductDtos)
        {
            var values = _mapper.Map<Product>(updateProductDtos);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductId == updateProductDtos.ProductId, values);
        }
    }
}
