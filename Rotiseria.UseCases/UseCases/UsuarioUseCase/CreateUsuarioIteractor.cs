using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.DTOs.ValidationDTO;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.PersonalException;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using Rotiseria.Entities;
using Rotiseria.Entities.Interfaces.Repositories;
using Rotiseria.UseCases.Specifications.UsuarioSpecifications;

namespace Rotiseria.UseCases.UseCases.UsuarioUseCase
{
    /// <summary>
    /// Clase que implementa el Input Port para crear un actorResponse.
    /// </summary>
    public class CreateUsuarioIteractor : ICreateUsuarioInputPort
    {
        readonly IUsuarioRepository _repository;
        readonly ICreateUsuarioPresenter _presenter;

      
        public CreateUsuarioIteractor(IUsuarioRepository repository, ICreateUsuarioPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        
        public async Task Handle(CreateUsuarioRequest creatUsuarioRequest)
        {
            List<ValidationErrorDTO> errors = new List<ValidationErrorDTO>();
            errors = ValidateUsuario(creatUsuarioRequest);
            WrapperCreateUsuario usuarioResponse = new();

            if (errors.Any())
            {
                usuarioResponse.ValidationErrors = errors;
                await _presenter.Handle(usuarioResponse);
                return;
            }

            Usuario newUsuario = new()
            {
                NombreUsuario = creatUsuarioRequest.NombreUsuario
            };

            try
            {
                await _repository.Create(newUsuario);
                await _repository.SaveChange();
                usuarioResponse.IdUsuario = newUsuario.Id;
            }
            catch (DBMySqlException ex)
            {
                usuarioResponse.ErrorNumber = ex.Number;
                usuarioResponse.Message = ex.MessageError;
            }
            finally
            {
                await _presenter.Handle(usuarioResponse);
            }
        }

        private List<ValidationErrorDTO> ValidateUsuario(CreateUsuarioRequest creatUsuarioRequest)
        {
            var specification = new CreateUsuarioSpecifications(creatUsuarioRequest);
            return specification.IsValid();
        }
    }
}
