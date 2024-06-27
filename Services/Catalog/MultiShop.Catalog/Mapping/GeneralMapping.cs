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

            CreateMap<ResultProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<UpdateProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<CreateProductDetailDto, ProductDetail>().ReverseMap();
            CreateMap<GetByIdProductDetailDto, ProductDetail>().ReverseMap();

            CreateMap<ResultProductImageDto, ProductImage>().ReverseMap();
            CreateMap<UpdateProductImageDto, ProductImage>().ReverseMap();
            CreateMap<CreateProductImageDto, ProductImage>().ReverseMap();
            CreateMap<GetByIdProductImageDto, ProductImage>().ReverseMap();
        }
    }
}
