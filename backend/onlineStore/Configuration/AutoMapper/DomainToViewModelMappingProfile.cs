using OnlineStore.API.Models;
using OnlineStore.Domain.Products.Entities;
using AutoMapper;

namespace OnlineStore.API.Configuration.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            //Mapeia de Order para OrderViewModel
            CreateMap<Product, ProductViewModel>();
        }
    }
}