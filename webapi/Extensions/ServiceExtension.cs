using Contrats;
using LoggerService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
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

    }


}
