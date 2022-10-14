using AutoMapper;
using Experis.Application.DTO;
using Experis.Domain.Entities;

namespace Experis.Application.AutoMapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
        }
    }
}
