using AlveoManagementServer.Services.Interfaces;
using AlveoManagementServer.SQLite;
//sing GoogleSheets;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.IO;
using System;
using System.Data.SQLite;

namespace AlveoManagementServer
{

    
    public class Program
    {

        public static async Task Main(string[] args)
        {

            Database databaseObject = new Database();

            /*//insert into database
            string insertQuery = "INSERT INTO test ('name', 'surname') VALUES (@name, @surname)";
            SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            insertCommand.Parameters.AddWithValue("@name", "Tinus");
            insertCommand.Parameters.AddWithValue("@surname", "Spangenberg");
            var insertResult = insertCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();

            Console.WriteLine("Rows Added : {0}", insertResult);
            Console.ReadKey();*/

            //select from database
            string selectQuery = "SELECT * FROM test";
            SQLiteCommand testCommand = new SQLiteCommand(selectQuery, databaseObject.dataConnection);
            databaseObject.OpenConnection();
            SQLiteDataReader selectResult = testCommand.ExecuteReader();
            if (selectResult.HasRows)
            {
                while (selectResult.Read())
                {
                    Console.WriteLine("name: {0} - Surname: {1}", selectResult["name"], selectResult["surname"]);
                }
            }
            databaseObject.CloseConnection();
            Console.ReadKey();





            IHost host = CreateHostBuilder(args).Build();

            using (IServiceScope serviceScope = host.Services.CreateScope())
            {
                //Services that need to run at application start
                //IGoogleSheetsService googleSheetsService = serviceScope.ServiceProvider.GetRequiredService<IGoogleSheetsService>();
                IStartupService startupService = serviceScope.ServiceProvider.GetRequiredService<IStartupService>();

                await host.RunAsync();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(configureLogging =>
                {
                    configureLogging.AddLog4Net("log4net.config");
                    configureLogging.AddConsole();
                    configureLogging.SetMinimumLevel(LogLevel.Information);
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.ConfigureAppConfiguration((hostingContext, config) =>
                    {
                        config.AddJsonFile("appsettings.json", false, true);
                    });
                    webBuilder.UseStartup<Startup>();
                });
    }
}
