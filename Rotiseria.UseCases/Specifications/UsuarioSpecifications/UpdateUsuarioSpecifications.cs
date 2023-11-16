
using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.DTOs.ValidationDTO;
using Rotiseria.BusinessRules.Interfaces.ValidationSpecification;

namespace Rotiseria.UseCases.Specifications.UsuarioSpecifications
{
    public class UpdateUsuarioSpecifications : ISpecification<UpdateUsuarioRequest>
    {
        readonly UpdateUsuarioRequest _entity;
        readonly List<ValidationErrorDTO> _errors = new List<ValidationErrorDTO>();

        public UpdateUsuarioSpecifications(UpdateUsuarioRequest entity)
        {
            _entity = entity;
        }

        public List<ValidationErrorDTO> IsValid()
        {
            if (_entity.IdUsuario == 0)
            {
                _errors.Add(new ValidationErrorDTO()
                {
                    PropertyName = "Id",
                    ErrorMessage = "Debe especficar el Id que desea actualizar"
                });
            }

            if (string.IsNullOrEmpty(_entity.NombreUsuario))
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Usuario",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            if (!string.IsNullOrEmpty(_entity.NombreUsuario) && _entity.NombreUsuario.Length > 45)
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nombre Usuario",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
