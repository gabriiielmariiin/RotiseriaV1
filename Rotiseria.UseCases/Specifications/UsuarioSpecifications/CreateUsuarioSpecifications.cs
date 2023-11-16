using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.DTOs.ValidationDTO;
using Rotiseria.BusinessRules.Interfaces.ValidationSpecification;

namespace Rotiseria.UseCases.Specifications.UsuarioSpecifications

{
    public class CreateUsuarioSpecifications : ISpecification<CreateUsuarioRequest>
    {
        readonly CreateUsuarioRequest _entity;
        readonly List<ValidationErrorDTO> _errors = new List<ValidationErrorDTO>();
        public CreateUsuarioSpecifications(CreateUsuarioRequest entity)
        {
            this._entity = entity;
        }

        public List<ValidationErrorDTO> IsValid()
        {
            if (string.IsNullOrEmpty(_entity.NombreUsuario))
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Usuario",
                    ErrorMessage = "El campo no puede ser nulo ni vacío."

                });
            }
            else if (_entity.NombreUsuario.Length > 45)
            {
                _errors.Add(new ValidationErrorDTO
                {
                    PropertyName = "Nomre Usuario",
                    ErrorMessage = "El campo no puede contener más de 45 caracteres."

                });

            }

            return _errors;
        }
    }
}
