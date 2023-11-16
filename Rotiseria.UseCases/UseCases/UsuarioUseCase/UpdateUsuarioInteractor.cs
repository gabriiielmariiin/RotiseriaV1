using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.DTOs.ValidationDTO;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using Rotiseria.Entities;
using Rotiseria.Entities.Interfaces.Repositories;
using Rotiseria.UseCases.Specifications.UsuarioSpecifications;



namespace Rotiseria.UseCases.UseCases.UsuarioUseCase
{
    public class UpdateUsuarioInteractor : IUpdateUsuarioInputPort
    {
        private readonly IUsuarioRepository _repository;
        private readonly IUpdateUsuarioPresenter _presenter;

        public UpdateUsuarioInteractor(IUsuarioRepository repository, IUpdateUsuarioPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(UpdateUsuarioRequest updateRequest, UpdateUsuarioRequest updateUsuarioRequest)
        {
            List<ValidationErrorDTO> errors = new List<ValidationErrorDTO>();
            WrapperUpdateUsuario usuarioResponse = new();

            try
            {
                //Valida los datos del usuario Response a actualizar.
                errors = ValidateUsuario(updateUsuarioRequest);

                if (errors.Any())
                {
                    // Manejar el caso en el que el usuarioResponse no cumpla con las validaciones.
                    // Devuelve un mensaje indicando que los datos del usuarioResponse no son validos.
                    usuarioResponse.ValidationErrors = errors;
                    await _presenter.Handle(usuarioResponse);
                    return;
                }

                // Obtener el usuarioResponse existente por su ID
                Usuario existingUsuario = await _repository.GetById(updateUsuarioRequest.IdUsuario);
                if (existingUsuario == null)
                {
                    // Manejar el caso en el que el usuarioResponse no existe
                    // Devuelve un mensaje indicando que el usuarioResponse no se encontró.
                    usuarioResponse.ErrorNumber = 404;
                    usuarioResponse.Message = $"El usuario con {updateUsuarioRequest.IdUsuario} no existe";
                    await _presenter.Handle(usuarioResponse);
                    return;
                }

                // Actualizar la información del usuarioResponse con los datos proporcionados
                existingUsuario.NombreUsuario = updateUsuarioRequest.NombreUsuario;

                // Realizar la actualización en el repositorio
                await _repository.Update(existingUsuario);
                await _repository.SaveChange();

                // Crear un objeto de respuesta exitosa
                usuarioResponse.IdUsuario = existingUsuario.Id;
                usuarioResponse.NombreUsuario = existingUsuario.NombreUsuario;

                // Enviar la respuesta al presentador
                await _presenter.Handle(usuarioResponse);
            }
            catch (Exception ex)
            {
                // Manejar cualquier error que pueda ocurrir durante la actualización
                usuarioResponse.Message = ex.Message;
            }
            finally
            {
                await _presenter.Handle(usuarioResponse);
            }
        }

        public Task Handle(UpdateUsuarioRequest updateUsuarioRequest)
        {
            throw new NotImplementedException();
        }

        private List<ValidationErrorDTO> ValidateUsuario(UpdateUsuarioRequest updateUsuarioRequest)
        {
            var specification = new UpdateUsuarioSpecifications(updateUsuarioRequest);
            return specification.IsValid();
        }
    }
}
