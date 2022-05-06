using OnlineStore.API.Models;
using OnlineStore.Domain.Products.Entities;
using AutoMapper;

namespace OnlineStore.API.Configuration.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}