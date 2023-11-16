using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;

namespace Rotiseria.Controllers.UsuarioControllers
{
    public class GetUsuarioByIdController : IGetUsuarioByIdController
    {
        readonly IGetUsuarioByIdInputPort _inputPort;
        readonly IGetUsuarioByIdPresenter _presenter;

        public GetUsuarioByIdController(IGetUsuarioByIdInputPort inputPort, IGetUsuarioByIdPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        async Task<WrapperSelectUsuario> IGetUsuarioByIdController.GetUsuario(int IdUsuario)
        {
            await _inputPort.Handle(IdUsuario);
            return _presenter.Usuario;
        }
    }
}