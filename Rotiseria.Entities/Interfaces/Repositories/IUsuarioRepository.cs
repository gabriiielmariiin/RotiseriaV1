namespace Rotiseria.Entities.Interfaces.Repositories
{

    /*El código define una interfaz llamada IUsuarioRepository
     * Esta interfaz especifica los métodos que debe implementar una clase de repositorio responsable de administrar entidades Usuario.*/
    public interface IUsuarioRepository : IUnitOfWork
    {
        Task<Usuario> GetById(int IdUsuario);/* Este método recupera una entidad Usuario por su IdUsuario (identificador único).*/
        Task Create(Usuario usuario);/*Este método crea una nueva entidad Usuario en la base de datos.*/
        Task Update(Usuario usuario);/* Este método actualiza una entidad Usuario existente en la base de datos.*/
        Task Delete(int IdUsuario);/*Este método elimina una entidad Usuario existente de la base de datos.*/
        Task<List<Usuario>> GetAllUsuarios();/*Este método recupera una lista de todas las entidades Usuario en la base de datos.*/
        //Task<List<Usuario>> GetAllusuariosByName(string name);
    }
}
