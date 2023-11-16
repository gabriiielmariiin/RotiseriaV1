using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;

namespace WebApi.EndPoint.Usuario
{
    public static class ProyectoProgramacionAllUsuarioEndPoint
    {
        public static WebApplication GetAllUsuarioEndPoint(this WebApplication app)
        {
            app.MapGet("/usuario", async (IGetAllUsuarioController controller) =>
            {
                var usuarios = await controller.GetUsuarios();

                if (usuarios == null)
                {
                    return Results.StatusCode(StatusCodes.Status500InternalServerError);
                }
                else if (usuarios.ErrorNumber != 0 && !string.IsNullOrEmpty(usuarios.Message))
                {
                    return Results.BadRequest( usuarios);
                }
                {
                    return Results.Ok(usuarios);
                }
            });

            return app;
        }
    }
}
