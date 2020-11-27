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

        protected override void OnStartup(StartupEventArgs e)
        {
            var builder = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContext<AppEmployeesDbContext>(options =>
            {
                options.UseSqlServer(Configuration["Data:DCTEIdentity:ConnectionString"]);
            });


            //services.AddDbContext<AppServiceDeskDbContext>(options =>
            //               options.UseSqlServer(
            //                   Configuration["Data:DCTEServiceDesk:ConnectionString"]));

            //services.AddDbContext<AppCustomersDbContext>(options =>
            //{
            //    options.UseSqlServer(Configuration["Data:DCTECustomers:ConnectionString"]);
            //});

            //services.AddTransient<IEmployeeRepository, EFEmployeeRepository>();
            services.AddTransient<IServiceDeskRepository, EFServiceDeskRepository>();
            //services.AddTransient<ICustomerRepository, EFCustomerRepository>();
        }
    }
}