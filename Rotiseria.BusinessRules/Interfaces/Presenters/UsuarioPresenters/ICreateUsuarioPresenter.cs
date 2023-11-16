using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.OutputPort;
using Rotiseria.BusinessRules.Wrappers.Usuario;


namespace Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters
{
    public interface ICreateUsuarioPresenter : ICreateUsuarioOutputPort
    {
        WrapperCreateUsuario Usuario { get; }

    }
}
