using Microsoft.OpenApi.Models;

namespace OnlineStore.API.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Projeto Final - Humano Tech",
                    Contact = new OpenApiContact { Name = "Júlia G Martins", Email = "julia.geremias.martins@gmail.com"}
                });
            });
        }
        
        public static void UseSwaggerSetup(this IApplicationBuilder app, IWebHostEnvironment environment)
        {
            if (environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                });
            }
        }
    }
}
