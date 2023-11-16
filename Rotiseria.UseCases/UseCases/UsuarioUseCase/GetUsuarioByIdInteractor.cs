using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using Rotiseria.Entities.Interfaces.Repositories;

namespace Rotiseria.UseCases.UseCases.UsuarioUseCase
{
    public class GetUsuarioByIdInteractor : IGetUsuarioByIdInputPort
    {
        private readonly IUsuarioRepository _repository;
        private readonly IGetUsuarioByIdPresenter _presenter;

        public GetUsuarioByIdInteractor(IUsuarioRepository repository, IGetUsuarioByIdPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }
        public async Task Handle(int idUsuario)
        {
            WrapperSelectUsuario usuarioResponse = new();

            try
            {
                var existingUsuario = await _repository.GetById(idUsuario);
                if (existingUsuario != null)
                {
                    usuarioResponse.IdUsuario = existingUsuario.Id;
                    usuarioResponse.NombreUsuario = existingUsuario.NombreUsuario;
                }
                else
                {
                    usuarioResponse.ErrorNumber = 404;
                    usuarioResponse.Message = "El Id proporcionado es inválido o no existe.";

                }

            }
            catch (Exception ex)
            {

                usuarioResponse.Message = ex.Message;

            }
            finally
            {
                await _presenter.Handle(usuarioResponse);
            }
        }
    }
}
