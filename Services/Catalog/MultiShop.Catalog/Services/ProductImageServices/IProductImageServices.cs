using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Services.ProductImageServices
{
    public interface IProductImageServices
    {
        Task<List<ResultProductImageDto>> GetAllProductImagesAsync();
        Task<GetByIdProductImageDto> GetByIdProductImageAsync(string id);
        Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
        Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
        Task DeleteProductImageAsync(string id);
    }
}
