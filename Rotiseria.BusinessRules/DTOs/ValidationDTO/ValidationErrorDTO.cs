using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.BusinessRules.DTOs.ValidationDTO
{
    public class ValidationErrorDTO
    {
        public string? PropertyName { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
