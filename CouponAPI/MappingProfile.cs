using AutoMapper;
using CouponAPI.Dtos;
using CouponAPI.Models;

namespace CouponAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Coupon, CouponDto>();
            CreateMap<CreateCouponDto, Coupon>();
            CreateMap<UpdateCouponDto, Coupon>();
        }
    }
}
