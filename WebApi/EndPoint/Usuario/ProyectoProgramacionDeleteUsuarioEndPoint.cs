using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;

namespace WebApi.EndPoint.Usuario
{
    public static class ProyectoProgramacionDeleteUsuarioEndPoint
    {
        public static WebApplication DeleteUsuarioEndPoint(this WebApplication app)
        {
            app.MapPut("/usuario/delete/{id}", async (IDeleteUsuarioController controller, int id) =>
            {
                var usuario = await controller.DeletetUsuario(id);
                if (usuario == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (usuario.ErrorNumber != 0 && !string.IsNullOrEmpty(usuario.Message))
                {
                    return Results.BadRequest(usuario);
                }

                return Results.Ok(usuario);
            });
            return app;
        }
    }
}