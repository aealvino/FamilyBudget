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

            Directory.CreateDirectory("logs");

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(
                    path: "../../../logs/log-.txt",
                    rollingInterval: RollingInterval.Day,
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();

            System.Windows.Forms.Application.ThreadException += (sender, args) =>
            {
                ExceptionHandlingMiddleware.HandleGlobalException(args.Exception);
            };

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<FamilyBudgetContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddBll();

            Task.Run(async () => await services.SeedRolesAsync()).GetAwaiter().GetResult();


            services.AddTransient<MainPage>();
            services.AddTransient<RegistrationForm>();

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<RegistrationForm>();

                var middleware = new ExceptionHandlingMiddleware(() =>
                {
                    System.Windows.Forms.Application.Run(mainForm);
                });

                middleware.Invoke();
            }
            Log.CloseAndFlush();
        }
    }
}
