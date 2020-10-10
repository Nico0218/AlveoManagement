using AlveoManagementServer.Services.Interfaces;
//sing GoogleSheets;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AlveoManagementServer {


    public class Program {

        public static async Task Main(string[] args) {
            IHost host = CreateHostBuilder(args).Build();

            using (IServiceScope serviceScope = host.Services.CreateScope()) {
                //Services that need to run at application start
                //IGoogleSheetsService googleSheetsService = serviceScope.ServiceProvider.GetRequiredService<IGoogleSheetsService>();
                IStartupService startupService = serviceScope.ServiceProvider.GetRequiredService<IStartupService>();

                await host.RunAsync();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(configureLogging => {
                    configureLogging.AddLog4Net("log4net.config");
                    configureLogging.AddConsole();
                    configureLogging.SetMinimumLevel(LogLevel.Information);
                })
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) => {
                        config.AddJsonFile("appsettings.json", false, true);
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
