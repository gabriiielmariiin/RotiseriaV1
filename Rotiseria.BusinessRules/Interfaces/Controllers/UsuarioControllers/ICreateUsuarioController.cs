using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.Wrappers.Usuario;

namespace Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers
{
    public interface ICreateUsuarioController
    {
        Task<WrapperCreateUsuario> CreateUsuario(CreateUsuarioRequest request);
    }
}
