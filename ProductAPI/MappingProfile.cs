using AutoMapper;
using ProductAPI.Dtos;
using ProductAPI.Models;

namespace ProductAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductDto>();
            CreateMap<CreateDto, Product>();
            CreateMap<UpdateDto, Product>();
        }
    }
}
