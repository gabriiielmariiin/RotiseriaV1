using MySql.Data.MySqlClient;
using Rotiseria.BusinessRules.PersonalException;
using Rotiseria.Entities.Interfaces.Repositories;
using Rotiseria.Repositories.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Rotiseria.Repositories.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        readonly ProgramacionpContext _context;

        public UsuarioRepository(ProgramacionpContext context)
        {
            _context = context;
        }

        public async Task Create(Entities.Usuario usuario)
        {
            try
            {
                await _context.AddAsync(usuario);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

         public async Task Delete(int IdUsuario)
        {
            try
            {
                var result = await _context.Usuarios.FirstOrDefaultAsync(a => a.Id == IdUsuario && a.IsDeleted == false);
                
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<List<Entities.Usuario>> GetAllUsuarios()
        {
            try
            {
                List<Entities.Usuario> result = new List<Entities.Usuario>();
                result = await _context.Usuarios.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<Entities.Usuario> GetById(int IdUsuario)
        {
            try
            {
                Entities.Usuario result = new Entities.Usuario();
                result = await _context.Usuarios.FirstOrDefaultAsync(a => a.Id ==  IdUsuario && a.IsDeleted == false);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(Entities.Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
        