using CDB.Application.DTOs;
using CDB.Application.Interfaces;
using CDB.Application.Services;
using CDB.Data.Repositories;
using CDB.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CDB.IoC
{
    public static class InfraEstrutura
    {

        public static IServiceCollection AddInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<ICalcularCDB, CalcularCDBRepository>();
            services.AddScoped<ICalcularCDBService, CalcularService>();

            return services;

        }
        
    }
}
