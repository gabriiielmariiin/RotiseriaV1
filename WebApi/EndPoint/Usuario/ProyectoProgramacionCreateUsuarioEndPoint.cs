using Rotiseria.BusinessRules.DTOs.UsuarioDTOs;
using Rotiseria.BusinessRules.Interfaces.Controllers.UsuarioControllers;

namespace WebApi.EndPoint.Usuario
{
    public static class ProyectoProgramacionCreateUsuarioEndPoint
    {
        public static WebApplication CreateUsuarioEndPoint(this WebApplication app)
        {
            app.MapPost("/create", async (CreateUsuarioRequest request, ICreateUsuarioController controller) =>
            {
                var result = await controller.CreateUsuario(request);

                if (!string.IsNullOrEmpty(result.Message) || result.ValidationErrors != null)
                {
                    return Results.BadRequest(result);
                }
                else
                {
                    return Results.Ok(result);
                }

            });

            return app;
        }
    }
}