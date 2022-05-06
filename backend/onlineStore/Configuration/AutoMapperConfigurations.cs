using OnlineStore.API.Configuration.AutoMapper;

namespace OnlineStore.API.Configuration
{
    public static class AutoMapperConfigurations
    {
        public static void AddAutoMapperConfigurations(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile), typeof(ViewModelToDomainMappingProfile));
        }
    }
}
