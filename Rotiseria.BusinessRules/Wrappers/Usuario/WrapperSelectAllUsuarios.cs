using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Wrappers.Usuario
{
    public class WrapperSelectAllUsuarios : BaseWrapper
    {
        public List<UsuarioResponse> Usuarios { get; set; } = new List<UsuarioResponse>();
    }
}
