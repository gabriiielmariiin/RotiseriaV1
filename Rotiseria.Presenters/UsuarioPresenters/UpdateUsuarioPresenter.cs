using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Presenters.UsuarioPresenters
{
    public class UpdateUsuarioPresenter : IUpdateUsuarioPresenter
    {
        public WrapperUpdateUsuario Usuario => throw new NotImplementedException();

        public Task Handle(WrapperUpdateUsuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
