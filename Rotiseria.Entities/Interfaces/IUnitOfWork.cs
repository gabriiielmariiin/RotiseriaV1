using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotiseria.Entities.Interfaces
{

    /*Esta interfaz especifica el método que debe implementar una clase de unidad de trabajo.*/
    /*Esto significa que todas las operaciones son exitosas y se confirman en la base de datos,
     * o ninguna de ellas es exitosa y la base de datos se restablece a su estado anterior*/
    public interface IUnitOfWork 
    {
        Task SaveChange();/*Este método guarda todos los cambios en la base de datos.*/
}
}

/*Este método es responsable de confirmar todos los cambios que se han realizado en la base de datos desde la última vez que se llamó al método SaveChange().
 * Si alguno de los cambios no se puede confirmar,
 * se deshace todos los cambios y la base de datos se devuelve a su estado anterior.*/