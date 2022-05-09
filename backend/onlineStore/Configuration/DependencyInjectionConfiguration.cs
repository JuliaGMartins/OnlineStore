using Infra.data.Repository;
using OnlineStore.Domain.Carts.Interfaces.Repository;
using OnlineStore.Domain.Carts.Interfaces.Services;
using OnlineStore.Domain.Carts.Services;
using OnlineStore.Domain.Orders.Interfaces.Repository;
using OnlineStore.Domain.Orders.Interfaces.Services;
using OnlineStore.Domain.Orders.Services;
using OnlineStore.Domain.Products.Interfaces.Repository;
using OnlineStore.Domain.Products.Interfaces.Services;
using OnlineStore.Domain.Products.Services;
using OnlineStore.Domain.Users.Interfaces;
using OnlineStore.Domain.Users.Interfaces.Services;
using OnlineStore.Domain.Users.Services;

namespace OnlineStore.API.Configuration
{
    public static class DependencyInjectionConfiguration
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartService, CartService>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();

            services.AddScoped<TokenService, TokenService>();
        }
    }
}
