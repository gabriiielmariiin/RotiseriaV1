using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Presenters.UsuarioPresenters
{
    public class GetUsuarioByIdPresenter : IGetUsuarioByIdPresenter
    {
        public WrapperSelectUsuario Usuario { get; private set; }

        public Task Handle(WrapperSelectUsuario usuario)
        {
            Usuario = new WrapperSelectUsuario
            {
                IdUsuario = usuario.IdUsuario,
                NombreUsuario = usuario.NombreUsuario,
                ErrorNumber = usuario.ErrorNumber,
                Message = usuario.Message
            };
            return Task.CompletedTask;
        }
    }
}