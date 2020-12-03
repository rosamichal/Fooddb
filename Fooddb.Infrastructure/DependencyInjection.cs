using Fooddb.Domain.Interfaces;
using Fooddb.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooddb.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient(typeof(IFooddbRepository<>), typeof(FooddbRepository<>));
            return services;
        }
    }
}
