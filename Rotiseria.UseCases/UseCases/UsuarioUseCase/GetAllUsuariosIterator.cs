using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.Interfaces.Getways.UsuarioGetways.InputPorts;
using Rotiseria.BusinessRules.Interfaces.Presenters.UsuarioPresenters;
using Rotiseria.BusinessRules.PersonalException;
using Rotiseria.BusinessRules.Wrappers.Usuario;
using Rotiseria.Entities.Interfaces.Repositories;

namespace Rotiseria.UseCases.UseCases.UsuarioUseCase
{
    public class GetAllUsuariosIterator : IGetAllUsuariosInputPort
    {
        private readonly IUsuarioRepository _repository;
        private readonly IGetAllUsuariosPresenter _presenter;

        public GetAllUsuariosIterator(IUsuarioRepository repository, IGetAllUsuariosPresenter presenter)
        {
            _repository = repository;
            _presenter = presenter;
        }

        public async ValueTask Handle()
        {
            WrapperSelectAllUsuarios usuariosResponse = new();
            try
            {
                var existingUsuarios = await _repository.GetAllUsuarios();

                if (existingUsuarios != null && existingUsuarios.Count > 0)
                {
                    foreach (var usuarios in existingUsuarios)
                    {
                        usuariosResponse.Usuarios.Add(new UsuarioResponse
                        {
                            IdUsuario = usuarios.Id,
                            NombreUsuario = usuarios.NombreUsuario
                        });
                    }
                }
                else
                {
                    usuariosResponse.ErrorNumber = 404;
                    usuariosResponse.Message = "No existen registros en la tabla Usuarios.";
                }

            }
            catch (DBMySqlException ex)
            {
                usuariosResponse.ErrorNumber = ex.Number;
                usuariosResponse.Message = ex.MessageError;

            }
            finally
            {
                await _presenter.Handle(usuariosResponse);
            }
        }
    }
}
