using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductServices
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task<GetByIdProductDto> GetByIdProductAsync(string id);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task CreateProductAsync(CreateProductDto createProductDto);
    }
}
