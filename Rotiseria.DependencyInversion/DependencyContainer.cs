using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Rotiseria.Controllers;
using Rotiseria.Presenters;
using Rotiseria.Repositories;
using Rotiseria.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Creas una carpeta dependencyinversion para organizar el código relacionado con la inyección de dependencias (DI)
 * La clase DependencyContainer es una clase central para la DI, por lo que es apropiado colocarla en esta carpeta.
 * La carpeta dependencyinversion también puede contener otras clases relacionadas con la DI
 * omo interfaces, clases de implementación y clases de proveedor de servicios.
 * la clase DependencyContainer se utiliza para registrar las clases de controlador Usuario con el contenedor DI
 * Al colocar esta clase en la carpeta dependencyinversion, estás organizando el código de DI de manera clara y consistente.*/
namespace Rotiseria.DependencyInversion
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProgramacionpServices(this IServiceCollection services, IConfiguration configuration, string connectionString)
        {
            services
                .AddServicesRepositories(configuration, connectionString)
                .AddServicesUseCases()
                .AddServicesPresenter()
                .AddServicesControllers();

            return services;
        }
    }
}
