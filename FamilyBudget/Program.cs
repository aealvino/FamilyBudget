using FamilyBudget.Infrastructure.Extensions;
using FamilyBudget.Persistence;
using FamilyBudget.UI.Forms;
using FamilyBudget.UI.middleware;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using System;
using System.IO;
using System.Windows.Forms;

namespace FamilyBudget
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ConfigureLogging();
            ConfigureGlobalExceptionHandling();


            var configuration = BuildConfiguration();
            var services = ConfigureServices(configuration);

            SeedDatabase(services).Wait();

            using var serviceProvider = services.BuildServiceProvider();
            RunApplication(serviceProvider);
            Log.CloseAndFlush();
        }
        private static void ConfigureLogging()
        {
            Directory.CreateDirectory("logs");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    path: "../../../logs/log-.txt",
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();
        }
        private static void ConfigureGlobalExceptionHandling()
        {
            System.Windows.Forms.Application.ThreadException += (sender, args) =>
            {
                ExceptionHandlingMiddleware.HandleGlobalException(args.Exception);
            };
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Exception ex = (Exception)args.ExceptionObject;
                ExceptionHandlingMiddleware.HandleGlobalException(ex);
            };

        }
        private static IConfiguration BuildConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
        }
        private static IServiceCollection ConfigureServices(IConfiguration configuration)
        {
            var services = new ServiceCollection();

            services.AddDbContext<FamilyBudgetContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddBll();

            services.AddTransient<MainPage>();
            services.AddTransient<RegistrationForm>();
            services.AddTransient<LoginForm>();
            services.AddTransient<StartForm>();
            services.AddTransient<StartFormAfterLogin>();

            return services;
        }
        private static void RunApplication(ServiceProvider serviceProvider)
        {
            var startForm = serviceProvider.GetRequiredService<StartForm>();
            var result = startForm.ShowDialog();

            var middleware = new ExceptionHandlingMiddleware(() =>
            {
                if (result == DialogResult.OK)
                {
                    var afterLoginForm = serviceProvider.GetRequiredService<StartFormAfterLogin>();
                    System.Windows.Forms.Application.Run(afterLoginForm);
                }
            });

            middleware.Invoke();
        }
        private static async Task SeedDatabase(IServiceCollection services)
        {
            await services.SeedRolesAsync();
        }
    }
}
