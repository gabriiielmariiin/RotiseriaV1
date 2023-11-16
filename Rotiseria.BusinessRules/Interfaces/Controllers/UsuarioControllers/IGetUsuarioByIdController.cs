using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers
{
    public interface IGetUsuarioByIdController
    {
        Task<WrapperSelectUsuario> GetUsuario(int IdUsuario);
    }
}
