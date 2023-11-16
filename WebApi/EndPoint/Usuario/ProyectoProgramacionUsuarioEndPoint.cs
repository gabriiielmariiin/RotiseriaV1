using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;

namespace WebApi.EndPoint.Usuario
{
    public static class ProyectoProgramacionUsuarioEndPoint
    {
        public static WebApplication GetUsuarioEndPoint(this WebApplication app)
        {
            app.MapGet("/usuario/{id}", async (IGetUsuarioByIdController controller, int id) =>
            {
                var usuario = await controller.GetUsuario(id);

                if (usuario == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);

                }
                else if (usuario.ErrorNumber != 0 && !string.IsNullOrEmpty(usuario.Message))
                {
                    return Results.BadRequest(usuario);

                }
                {
                    return Results.Ok(usuario);
                }
            });

            return app;
        }
    }
}