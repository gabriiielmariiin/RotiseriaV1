using System.Collections.Generic;
using Rotiseria.BusinessRules.DTOs.ValidationDTO;

namespace Rotiseria.BusinessRules.Wrappers.Usuario
{
    public class WrapperDeleteUsuario : BaseWrapper
    {
        public int IdUsuario { get; set; }

        public List<ValidationErrorDTO>? ValidationErrors { get; set; }
    }
}
