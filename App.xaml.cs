using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DependencyInjection1.Services;
using DependencyInjection1.Models;


namespace DependencyInjection1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost host;

        public App()
        {
            // Create the generic host builder
            host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.AddJsonFile("appsettings.local.json", optional: true);
                })
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(context.Configuration, services);
                })
                .ConfigureServices(logging =>
                {

                })
                .Build();
        }

        private void ConfigureServices( IConfiguration configuration, 
            IServiceCollection services)
        {
            // Register all the services

            services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
            services.AddScoped<ISampleService, SampleService>();

            services.AddSingleton<MainWindow>();

        }

        protected override async void OnStartup( StartupEventArgs e)
        {
            await host.StartAsync();

            // Get the main window from the service provider and show it
            var mainWindow = host.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit( ExitEventArgs e)
        {
            using (host)
            {
                await host.StopAsync(TimeSpan.FromSeconds(5));
            }

            base.OnExit(e);
        }
    }
}
