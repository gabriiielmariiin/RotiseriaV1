using Microsoft.Extensions.DependencyInjection;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.OutputPort;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.Presenters.UsuarioPresenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddServicesPresenter(this IServiceCollection services)
        {
            services.AddScoped<GetAllUsuarioPresenter>();

            services.AddScoped<IGetAllUsuariosOutputPort, GetAllUsuarioPresenter>();

            services.AddScoped<IGetAllUsuariosPresenter, GetAllUsuarioPresenter>();



            services.AddScoped<ICreateUsuarioPresenter, CreateUsuarioPresenter>();

            services.AddScoped<IDeleteUsuarioPresenter, DeleteUsuarioPresenter>();

            services.AddScoped<IGetUsuarioByIdPresenter, GetUsuarioByIdPresenter>();

            services.AddScoped<IUpdateUsuarioPresenter, UpdateUsuarioPresenter>();

            return services;
        }
    }
}