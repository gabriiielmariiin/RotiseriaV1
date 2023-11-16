using Rotiseria.BusinessRules.Wrappers.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.OutputPort
{
    public interface IGetAllUsuariosOutputPort
    {
        ValueTask Handle(WrapperSelectAllUsuarios usuarios);
    }
}
