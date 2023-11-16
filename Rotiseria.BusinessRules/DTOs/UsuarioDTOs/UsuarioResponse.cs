using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// DTO que representa la información de un usuario que se envía como respuesta 
/// desde la capa de negocio al controlador o presentación.
namespace Rotiseria.BusinessRules.DTOs.UsuarioDTOs
{
    public class UsuarioResponse
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
    }
}
