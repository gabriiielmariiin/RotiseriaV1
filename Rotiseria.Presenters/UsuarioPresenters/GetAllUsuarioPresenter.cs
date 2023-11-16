using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Presenters.UsuarioPresenters
{
    public class GetAllUsuarioPresenter : IGetAllUsuariosPresenter
    {
        public WrapperSelectAllUsuarios Usuarios { get; private set; }

        public ValueTask Handle(WrapperSelectAllUsuarios usuarios)
        {
            //foreach (var usuario in usuario)
            //{
            //    Usuarios.Append(new WrapperSelectUsuario
            //    {
            //        IdUsuarios = usuario.IdUsuario,
            //        NombreUsuario = usuario.NombreUsuario,
            //        ErrorNumber = usuarios.ErrorNumber,
            //        Message = string.IsNullOrEmpty(usuario.Message) ? "" : usuario.Message

            //    });
            //}
            Usuarios = usuarios;
            return ValueTask.CompletedTask;
        }
    }
}
