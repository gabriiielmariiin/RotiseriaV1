using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;

namespace Rotiseria.Controllers.UsuarioControllers
{
    /*Las clases creadas en la carpeta controller sirven para manejar las interacciones
     * entre la capa de presentación y la capa de negocio.
     * la clase CreateUsuarioController se encarga de manejar la creación de nuevos usuarios en el sistema.*/
     
    public class CreateUsuarioController: ICreateUsuarioController
    {

        /*La clase CreateUsuarioController recibe como parámetros en su constructor
         * un ICreateUsuarioInputPort y un ICreateUsuarioPresenter*/
        readonly ICreateUsuarioInputPort _inputPort;
        readonly ICreateUsuarioPresenter _presenter;
        /* El ICreateUsuarioInputPort es una interfaz que define el método Handle()
         * el cual se encarga de procesar la solicitud de creación de usuario
         * El ICreateUsuarioPresenter es una interfaz que define el método Usuario
         * el cual se encarga de obtener la información del usuario creado.*/

        /*Cuando se llama al método CreateUsuario(), la clase CreateUsuarioController primero llama al método Handle()
        *  del ICreateUsuarioInputPort, pasándole la solicitud de creación de usuario.
        *  El ICreateUsuarioInputPort se encarga de validar la solicitud
        *  y, si es válida, de crear el nuevo usuario en la base de datos.*/
        public CreateUsuarioController(ICreateUsuarioInputPort inputPort, ICreateUsuarioPresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async Task<WrapperCreateUsuario> CreateUsuario(CreateUsuarioRequest request)
        {
            await _inputPort.Handle(request);

            return _presenter.Usuario;
        }
    }
}
