using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotiseria.BusinessRules.DTOs.ValidationDTO;

namespace Rotiseria.BusinessRules.Wrappers.Usuario
{
    public class WrapperCreateUsuario : BaseWrapper
    {
        public int IdUsuario { get; set; }
        public List<ValidationErrorDTO>? ValidationErrors { get; set; }
    }
}
