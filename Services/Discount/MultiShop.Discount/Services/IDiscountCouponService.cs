using MultiShop.Discount.Dtos;

namespace MultiShop.Discount.Services
{
    public interface IDiscountCouponService
    {
        Task<List<ResultDiscountCouponDto>> GetAllDiscountCouponsAsync();
        Task<GetByIdDiscountCouponDto> GetByIdDiscountCouponAsync(int id);
        Task UpdateDiscountCouponAsync(UpdateDiscountCouponDto updateCouponDto);
        Task DeleteDiscountCouponAsync(int id);
        Task CreateDiscountCouponAsync(CreateDiscountCouponDto createCouponDto);
    }
}
