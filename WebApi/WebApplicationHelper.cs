using WebApi.EndPoint.Usuario;
using Rotiseria.DependencyInversion;
namespace WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
        {
            // Configurar APIExplorer para descubrir y exponer
            // los metadatos de los endpoints de la aplicación.
            builder.Services.AddEndpointsApiExplorer();

            // Agregar el generador que construye los objetos de
            // documentación de Swagger con la funcionalidad del APIExplorer.
            builder.Services.AddSwaggerGen();

            // Registrar los servicios de la aplicación
            //Ejecuta el método AddProyectoProgramacionServices en el objeto Services. Este método se encarga de agregar todos los servicios necesarios para tu aplicación.
            //builder.Configuration: Esto representa la configuración de la aplicación. La configuración de la aplicación es un mecanismo para almacenar datos de configuración,
            //como cadenas de conexión a bases de datos, que se utilizan para configurar los servicios de la aplicación.
            //"MySqlProgramacionpDB": Esto es el nombre de la cadena de conexión que se utilizará para configurar los servicios de la aplicación.
            //La cadena de conexión contiene información sobre cómo conectarse a la base de datos, como el proveedor de la base de datos, el nombre de la base de datos, el nombre de usuario y la contraseña.
            builder.Services.AddProgramacionpServices(
                builder.Configuration, "MySqlProgramacionpDB");

            // Agregar el servicio CORS para clientes que se ejecutan
            // en el navegador Web (como Blazor WebAssembly).
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(config =>
                {
                    config.AllowAnyMethod();
                    config.AllowAnyHeader();
                    config.AllowAnyOrigin();
                });
            });
            try
            {
                return builder.Build();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return default;
            }


        }
        public static WebApplication ConfigureWebApplication(
            this WebApplication app)
        {
            // Habilitar el middleware para servir el documento
            // JSON generado y la interfaz UI de Swagger en el
            // ambiente de desarrollo.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Registrar los endpoints de la aplicación
            
            app.GetAllUsuarioEndPoint();
            app.GetUsuarioEndPoint();
            app.CreateUsuarioEndPoint();
            app.DeleteUsuarioEndPoint();

            // Agregar el Middleware CORS
            app.UseCors();

            return app;
        }
    }
}
