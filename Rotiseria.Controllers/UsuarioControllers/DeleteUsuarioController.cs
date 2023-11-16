using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;

namespace Rotiseria.Controllers.UsuarioControllers
{
    /*La clase DeleteUsuarioController se encarga de manejar las solicitudes para eliminar un usuario del sistema. */
    public class DeleteUsuarioController : IDeleteUsuarioController
    {
        readonly IDeleteUsuarioInputPort _inputPort;
        readonly IDeleteUsuarioPresenter _presenter;

        public DeleteUsuarioController(IDeleteUsuarioInputPort inputPort, IDeleteUsuarioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperDeleteUsuario> DeletetUsuario(int Usuario)
        {
            await _inputPort.Handle(Usuario);
            return _presenter.Usuario;
        }
    }
}

/*La clase DeleteUsuarioController se encarga de manejar las solicitudes para eliminar un usuario del sistema. */
/*Constructor: El constructor inicializa los campos _inputPort y _presenter, 
 * que se utilizan para interactuar con la capa de lógica de negocio y la capa de presentación,*/

/*Método DeleteUsuario: Este método toma un int que representa el ID de usuario como entrada.
 *  Luego, llama al método Handle del _inputPort, pasándole el ID de usuario
 *  El _inputPort es responsable de validar el ID de usuario y eliminar el usuario correspondiente de la base de datos.*/
/*_presenter.Usuario: Después de que se elimina el usuario, el método recupera la información del usuario eliminado del _presenter.
 * Esta información luego se devuelve al llamador.*/