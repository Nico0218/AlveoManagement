using AlveoManagementServer.Services;
using AlveoManagementServer.Services.Interfaces;
using DBProviderBase.Classes;
using DBProviderBase.Enums;
using DBProviderBase.Interfaces;
//using GoogleSheets;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SQLiteProvider.Services;
using System;

namespace AlveoManagementServer
{
    public class Startup
    {
        private const string msgDataStoreTypeError = "Not supported data store type";
        private readonly string AllowAllCors = "AllowAllCors";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Init DB provider
            ConnectionSettings connectionSettings = new ConnectionSettings();

            services.Configure<ConnectionSettings>(Configuration.GetSection(typeof(ConnectionSettings).Name));

            DBProviderType dataStoreType = (DBProviderType)Enum.Parse(typeof(DBProviderType), Configuration.GetSection($"{typeof(ConnectionSettings).Name}:DataStoreType").Value.ToString());
            switch (dataStoreType)
            {
                case DBProviderType.SQLiteProvider:
                    services.AddSingleton<IDataService, SQLiteClient>();
                    break;
                default:
                    throw new Exception(msgDataStoreTypeError);
            }

            //services.AddScoped<IGoogleSheetsService, GoogleSheetsService>();            
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IInventoryService, InventoryService>();
            services.AddScoped<IPersonnelService, PersonnelService>();
            services.AddScoped<IGanttDataService, GanttDataService>();
            services.AddScoped<IStartupService, StartupService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IQuoteService, QuoteService>();
            services.AddScoped<IProjectService, ProjectService>();

            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Alveo Management API V1", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(AllowAllCors, builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Alveo Management API V1");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(AllowAllCors);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
