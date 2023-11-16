using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.DTOs.UsuarioDTOs
{
    public class UpdateUsuarioRequest
    {

        public int IdUsuario { get; set; }
        public string? NombreUsuario { get; set; }
    }
}
