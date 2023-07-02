﻿using ACX.Application.Common;
using ACX.LoggerService;

namespace ACX.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        }

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
            services.Configure<IISOptions>(options =>
                {
                
                });
        public static void ConfigureLoggerService(this IServiceCollection services)=> services.AddSingleton<ILoggerManager,LoggerManager>();
    }
}