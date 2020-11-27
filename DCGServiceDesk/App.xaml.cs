using DCGServiceDesk.Context;
using DCGServiceDesk.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DCGServiceDesk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }
        public App()
        {
            IServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            ServiceProvider = services.BuildServiceProvider();
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppEmployeesDbContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:DCTEIdentity:ConnectionString"]);
            });

            services.AddDbContext<AppIdentityDbContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:DCTEIdentity:ConnectionString"]);
            });

            services.AddTransient<IServiceDeskRepository, EFServiceDeskRepository>();

            services.AddSingleton<MainWindow>();
            //services.AddScoped<MainWindow>();
        }
        protected override void OnStartup(StartupEventArgs startupEventArgs)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile(@"X:\Programowanie\C#\Programy WPF\DCGServiceDesk\DCGServiceDesk\appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            //MainWindow mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            

            //mainWindow.Show();
        }
    }
}