using FamilyBudget.Application.Mappings;
using FamilyBudget.Persistence;
using FamilyBudget.Persistence.Repositories.Interfaces;
using FamilyBudget.Persistence.Repositories;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FamilyBudget.Domain.Interfaces;
using FamilyBudget.Infrastructure.Services;
using FamilyBudget.Persistence.Seeders;
using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.ApplicationCore.Validations;
using FluentValidation;

namespace FamilyBudget.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IServiceCollection AddEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FamilyBudgetContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
        public static IServiceCollection AddBll(this IServiceCollection services)
        {
            var config = TypeAdapterConfig.GlobalSettings;

            config.Scan(typeof(UserMappingConfig).Assembly);

            services.AddSingleton(config);
            services.AddScoped<IMapper, ServiceMapper>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddValidatorsFromAssemblyContaining<UserRegisterDtoValidator>();
            services.AddValidatorsFromAssemblyContaining<UserLoginDTOValidation>();
            services.AddSingleton<IUserSessionService, UserSessionService>();


            services.AddScoped<IFamilyService, FamilyService>();
            return services;
        }
        public static async Task SeedRolesAsync(this IServiceCollection services)
        {
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var context = serviceProvider.GetRequiredService<FamilyBudgetContext>();
                await RoleSeeder.SeedRolesAsync(context);
            }
        }
    }
}
