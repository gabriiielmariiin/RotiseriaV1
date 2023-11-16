using Rotiseria.BusinessRules.DTOs.ValidationDTO;

namespace Rotiseria.BusinessRules.Interfaces.ValidationSpecification
{

    /// Iinterfaz que se utiliza para representar especificaciones de validación
    /// en el sistema. <summary>
    /// Iinterfaz que se utiliza para representar especificaciones de validación
    /// </summary>
    /// <typeparam name="T"></typeparam>
    ///  /// Objeto al que se aplica la especificación de validación.
    /// </typeparam>
    public interface ISpecification<T> where T : class
    {

        /// Valida el objeto según la especificación y devuelve una lista de 
        /// errores de validación.
        /// </summary>
        /// <returns>Una lista de errores de validación. Si la validación es exitosa, 
        /// la lista estará vacía.</returns>
        List<ValidationErrorDTO> IsValid();
    }
}
