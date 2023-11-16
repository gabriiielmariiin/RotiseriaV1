using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;

namespace Rotiseria.Controllers.UsuarioControllers
{
    public class GetAllUsuarioController : IGetAllUsuarioController
    {
        readonly IGetAllUsuariosInputPort _inputPort;
        readonly IGetAllUsuariosPresenter _presenter;

        public GetAllUsuarioController(IGetAllUsuariosInputPort inputPort, IGetAllUsuariosPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<WrapperSelectAllUsuarios> GetUsuarios()
        {
            await _inputPort.Handle();
            return _presenter.Usuarios;
        }
    }
}
