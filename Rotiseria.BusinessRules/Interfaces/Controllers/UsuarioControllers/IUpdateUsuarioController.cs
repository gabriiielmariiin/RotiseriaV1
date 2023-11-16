using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers
{
    public interface IUpdateUsuarioController
    {
        Task<WrapperCreateUsuario> UpdateUsuario(UpdateUsuarioRequest request);
    }
}
