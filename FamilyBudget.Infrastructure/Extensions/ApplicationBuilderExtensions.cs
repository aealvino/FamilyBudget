using FamilyBudget.Application.Mappings;
using FamilyBudget.Persistence;
using FamilyBudget.Persistence.Repositories.Interfaces;
using FamilyBudget.Persistence.Repositories;
using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using FamilyBudget.Domain.Interfaces;
using FamilyBudget.Infrastructure.Services;

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

            return services;
        }
    }
}
