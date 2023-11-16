using Microsoft.Extensions.DependencyInjection;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.UseCases.UseCases.UsuarioUseCase;

namespace Rotiseria.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesUseCases(this IServiceCollection services)
        {
            services.AddScoped<ICreateUsuarioInputPort, CreateUsuarioIteractor>();

            services.AddScoped<IDeleteUsuarioInputPort, DeleteUsuarioInteractor>();

            services.AddScoped<IUpdateUsuarioInputPort, UpdateUsuarioInteractor>();

            services.AddScoped<IGetUsuarioByIdInputPort, GetUsuarioByIdInteractor>();

            services.AddScoped<IGetAllUsuariosInputPort, GetAllUsuariosIterator>();

            return services;

        }
    }
}
