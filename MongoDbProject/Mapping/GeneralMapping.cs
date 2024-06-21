using AutoMapper;
using MongoDbProject.Dtos.CategoryDtos;
using MongoDbProject.Dtos.ProductDtos;
using MongoDbProject.Entities;

namespace MongoDbProject.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDtos>().ReverseMap();
            CreateMap<Category, CreateCategoryDtos>().ReverseMap();
            CreateMap<Category, UpdateCategoryDtos>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDtos>().ReverseMap();

            CreateMap<Product, ResultProductDtos>().ReverseMap();
            CreateMap<Product, CreateProductDtos>().ReverseMap();
            CreateMap<Product, UpdateProductDtos>().ReverseMap();
            CreateMap<Product, GetByIdProductDtos>().ReverseMap();
        }
    }
}
