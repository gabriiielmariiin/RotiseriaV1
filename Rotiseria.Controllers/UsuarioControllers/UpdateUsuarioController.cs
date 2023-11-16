using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;
using Rotiseria.BusinessRules.Wrappers.Usuario;

namespace Rotiseria.Controllers.UsuarioControllers
{
    public class UpdateUsuarioController : IUpdateUsuarioController
    {
        public Task<WrapperCreateUsuario> UpdateUsuario(UpdateUsuarioRequest request)
        {
            throw new NotImplementedException();
        }
    }
}