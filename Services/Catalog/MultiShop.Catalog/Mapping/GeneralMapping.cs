using AutoMapper;
using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Dtos.ProductDtos;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<GetByIdCategoryDto, Category>().ReverseMap();

            CreateMap<ResultProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<GetByIdProductDto, Product>().ReverseMap();

            CreateMap<ResultProductDetailDto, Product>().ReverseMap();
            CreateMap<UpdateProductDetailDto, Product>().ReverseMap();
            CreateMap<CreateProductDetailDto, Product>().ReverseMap();
            CreateMap<GetByIdProductDetailDto, Product>().ReverseMap();

            CreateMap<ResultProductImageDto, Product>().ReverseMap();
            CreateMap<UpdateProductImageDto, Product>().ReverseMap();
            CreateMap<CreateProductImageDto, Product>().ReverseMap();
            CreateMap<GetByIdProductImageDto, Product>().ReverseMap();
        }
    }
}
