using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rotiseria.Entities.Common;


namespace Rotiseria.Entities
{
    /* La palabra clave partial significa que la clase Usuario puede ser parcial. Una clase parcial es una clase que se divide en dos o más partes
     * En este caso, la clase Usuario se divide en una parte que se define en el archivo Usuario.cs y otra parte que se define en un archivo separado.*/


/*significa que la clase Usuario hereda de la clase EntityCommon
 *  La clase EntityCommon es una clase base que proporciona funcionalidad común para todas las clases que representan entidades en un sistema de base de datos.*/

public partial class  Usuario : EntityCommon
{

    public string? NombreUsuario { get; set; }
    public string? ApellidoUsuario { get; set; }
    public int?  Cuil {get; set; }   
    public string? CorreoElectronico { get; set; }

    public int? Telefono { get; set; }   

    public int? Rol {get; set; }



}
}
