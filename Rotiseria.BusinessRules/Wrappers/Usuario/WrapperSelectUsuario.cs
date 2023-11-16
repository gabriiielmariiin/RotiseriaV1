using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.Wrappers.Usuario
{
    public class WrapperSelectUsuario : BaseWrapper
    {
        public int IdUsuario { get; set; }
        public string? NombreUsuario { get; set; }
    }
}
