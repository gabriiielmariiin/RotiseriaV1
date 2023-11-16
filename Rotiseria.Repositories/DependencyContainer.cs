using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotiseria.Entities.Interfaces.Repositories;
using Rotiseria.Repositories.Context;
using Rotiseria.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Repositories
{
    public static class DependencyContainer
    {

        public static IServiceCollection AddServicesRepositories(this IServiceCollection services,
            IConfiguration configuration, string connectionStringName)
        {
            services.AddDbContext<ProgramacionpContext>(options =>
            options.UseMySQL(configuration
            .GetConnectionString(connectionStringName)));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            return services;
        }
    }
}
