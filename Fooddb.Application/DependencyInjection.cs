using AutoMapper;
using Fooddb.Application.Interfaces;
using Fooddb.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Fooddb.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            //services.AddTransient<IIngredientService, IngredientService>();
            services.Scan(scan => scan
                .FromExecutingAssembly()
                .AddClasses(classess => classess.Where(c => c.Name.EndsWith("Service")))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
