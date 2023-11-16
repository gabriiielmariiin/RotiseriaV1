using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Los presenters son utilizados en la arquitectura Clean Architecture para separar la capa de presentación de la capa de negocio
 * La capa de presentación es responsable de mostrar la información al usuario
 * mientras que la capa de negocio es responsable de la lógica de negocio
 * Los presenters actúan como intermediarios entre estas dos capas, 
 * traduciendo los datos de la capa de negocio a un formato que la capa de presentación pueda entender.*/
namespace Rotiseria.Presenters.UsuarioPresenters
{
    public class CreateUsuarioPresenter : ICreateUsuarioPresenter
    {
        public WrapperCreateUsuario Usuario { get; private set; } = new WrapperCreateUsuario();

       

        public Task Handle(WrapperCreateUsuario usuario)
        {

            Usuario.ErrorNumber = usuario.ErrorNumber;
            Usuario.ValidationErrors = usuario.ValidationErrors;
            Usuario.Message = usuario.Message;
            Usuario.IdUsuario = usuario.IdUsuario;
            return Task.CompletedTask;
        }
    }
}
/*n el caso de la clase CreateUsuarioPresenter, 
 * su función es convertir los datos de un objeto WrapperCreateUsuario en un formato que la capa de presentación pueda entender
 * Esto incluye,Copiar los errores y los mensajes del objeto WrapperCreateUsuario al objeto Usuario
 * Establecer el ID de usuario en el objeto Usuario si se creó un nuevo usuario.*/
/*De esta manera, la capa de presentación puede acceder a la información
 * relevante del usuario sin tener que preocuparse por los detalles de la capa de negocio.*/