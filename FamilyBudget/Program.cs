using FamilyBudget.Persistence;
using FamilyBudget.UI.middleware;
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

            // Настройка Serilog
            Directory.CreateDirectory("logs");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    path: "../../../logs/log-.txt",
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();

            Application.ThreadException += (sender, args) =>
            {
                ExceptionHandlingMiddleware.HandleGlobalException(args.Exception);
            };

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<FamilyBudgetContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<MainPage>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<MainPage>();

                var middleware = new ExceptionHandlingMiddleware(() =>
                {
                    Application.Run(mainForm);
                });

                middleware.Invoke();
            }
            Log.CloseAndFlush();
        }
    }
}
