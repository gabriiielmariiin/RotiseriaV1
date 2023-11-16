

using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;

namespace Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts
{
    public interface IUpdateUsuarioInputPort
    {
        Task Handle(UpdateUsuarioRequest updateUsuarioRequest);
    }
}
