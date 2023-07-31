using CDB.Application.Mapping;
using System.Runtime.CompilerServices;

namespace CDB.API.MappingConfig
{
    public static class AutoMapperConfig
    {

        public static void AddAutoMapperConfig(this IServiceCollection services)
        {

            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(AutoMapperProfile));

        }

    }
}
