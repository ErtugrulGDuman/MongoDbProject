using MongoDbProject.Dtos.CategoryDtos;

namespace MongoDbProject.Services.CategoryServices
{
    public interface ICategoryService
    {
        Task<List<ResultCategoryDtos>> GetAllCategoryAsync();
        Task CreateCategoryAsync(CreateCategoryDtos createCategoryDto);
        Task UpdateCategoryAsync(UpdateCategoryDtos updateCategoryDto);
        Task DeleteCategoryAsync(string id);
        Task<GetByIdCategoryDtos> GetByIdCategoryAsync(string id);
    }
}
