using Microsoft.Extensions.DependencyInjection;
using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;
using Rotiseria.Controllers.UsuarioControllers;

namespace Rotiseria.Controllers
{
    /*
La clase DependencyContainer sirve para registrar las clases de controlador 
    para la entidad Usuario con el contenedor de inyección de dependencias*/
    public static class DependencyContainer
    {
        /*el método AddServicesControllers registra las siguientes clases de controlador:*/
        public static IServiceCollection AddServicesControllers(this IServiceCollection services)
        {
            services.AddScoped<ICreateUsuarioController, CreateUsuarioController>();
            /*para manejar las solicitudes para crear nuevos usuarios*/
            services.AddScoped<IDeleteUsuarioController, DeleteUsuarioController>();
            /*para manejar las solicitudes para eliminar usuarios*/
            services.AddScoped<IUpdateUsuarioController, UpdateUsuarioController>();
            /*para manejar las solicitudes para actualizar la información del usuario*/
            services.AddScoped<IGetUsuarioByIdController, GetUsuarioByIdController>();
            /*para manejar las solicitudes para recuperar la información del usuario por ID*/
            services.AddScoped<IGetAllUsuarioController, GetAllUsuarioController>();
            /*para manejar las solicitudes para recuperar todos los usuarios*/
            return services;

        }
    }
}
/*Al registrar estas clases de controlador con el contenedor DI,
 *  la aplicación puede obtener fácilmente instancias de estas clases sin tener que crearlas manualmente.
 *  Esto simplifica el proceso de resolución de dependencias y promueve la vinculación suelta entre los componentes.*/

/* la clase DependencyContainer desempeña un papel crucial en la gestión y configuración de dependencias para las clases de controlador Usuario
 * asegurando un proceso de resolución de dependencias fluido y eficiente.*/