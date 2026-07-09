using Sales.API.Dtos;
using Sales.API.Entities;

namespace Sales.API.Services.Categories
{
    public interface ICategoryService
    {
        Task<ResponseDto<CategoryEntity>> CreateAsync(CategoryEntity category);

        
    }
}