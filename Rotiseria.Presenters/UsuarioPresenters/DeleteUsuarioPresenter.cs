using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Presenters.UsuarioPresenters
{
    public class DeleteUsuarioPresenter : IDeleteUsuarioPresenter
    {
        public WrapperDeleteUsuario Usuario { get; private set; } = new WrapperDeleteUsuario();

        public Task Handle(WrapperDeleteUsuario usuario)
        {
            Usuario.ErrorNumber = usuario.ErrorNumber;
            Usuario.Message = usuario.Message;
            Usuario.IdUsuario = usuario.IdUsuario;
            return Task.CompletedTask;
        }
    }
}
