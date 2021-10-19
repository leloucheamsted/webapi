using Contrats;
<<<<<<< HEAD
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
=======
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
>>>>>>> 5e5f25b94ae9ecca6b03176c029d8639e4d11003
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
<<<<<<< HEAD
using Repository;
=======
>>>>>>> 5e5f25b94ae9ecca6b03176c029d8639e4d11003
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapi
{
    public static class ServiceExtension
    {
         // CORS CONFIGURATION 
        public static void ConfigureCors(this IServiceCollection services) =>
 services.AddCors(options =>
 {
     options.AddPolicy("CorsPolicy", builder =>
     builder.AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());
 });

        // IIS CONFIGURATION 
        public static void ConfigureIISIntegration(this IServiceCollection services) =>
 services.Configure<IISOptions>(options =>
 {

     
 });
        // logger service
        public static void ConfigureLoggerService(this IServiceCollection services) =>
services.AddScoped<ILoggerManager, LoggerManager>();

<<<<<<< HEAD
        // CONNECTION SQL SERVER
        public static void ConfigureSqlContext(this IServiceCollection services,
IConfiguration configuration) =>
 services.AddDbContext<RepositoryContext>(opts =>
 opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b =>
b.MigrationsAssembly("webapi")));

        // repository Manager
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
 services.AddScoped<IRepositoryManager, RepositoryManager>();
    }





=======
    }


>>>>>>> 5e5f25b94ae9ecca6b03176c029d8639e4d11003
}
