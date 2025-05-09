using FamilyBudget.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

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
    }
}
