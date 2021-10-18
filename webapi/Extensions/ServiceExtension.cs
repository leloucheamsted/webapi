using Contrats;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Repository;
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





}
