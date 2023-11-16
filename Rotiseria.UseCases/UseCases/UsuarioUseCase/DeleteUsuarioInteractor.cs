using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.PersonalException;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using Rotiseria.Entities.Interfaces.Repositories;

namespace Rotiseria.UseCases.UseCases.UsuarioUseCase
{
    public class DeleteUsuarioInteractor : IDeleteUsuarioInputPort
    {
        private readonly IUsuarioRepository _repository;
        private readonly IDeleteUsuarioPresenter _presenter;

        public DeleteUsuarioInteractor(IUsuarioRepository repository, IDeleteUsuarioPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async Task Handle(int idUsuario)
        {

            WrapperDeleteUsuario usuarioResponse = new();
            try
            {
                // Eliminar el usuario
                await _repository.Delete(idUsuario);
                await _repository.SaveChange();
                usuarioResponse.IdUsuario = idUsuario;
            }
            catch (DBMySqlException ex)
            {
                // Manejar errores
                usuarioResponse.ErrorNumber = ex.Number;
                usuarioResponse.Message = ex.MessageError;
            }
            finally
            {
                // Notificar al presentador que se eliminó el usuario.
                await _presenter.Handle(usuarioResponse);
            }

        }
    }
}
