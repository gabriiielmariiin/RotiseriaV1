using Microsoft.EntityFrameworkCore;
using Rotiseria.Entities;
using System.Reflection;

namespace Rotiseria.Repositories.Context;

public partial class ProgramacionpContext : DbContext
{
    // Este código define un contexto de base de datos llamado ProgramacionpContext
    // que hereda de DbContext en Entity Framework Core.




    // El constructor recibe opciones de configuración de DbContext.
    public ProgramacionpContext(DbContextOptions<ProgramacionpContext> options) 
        : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseMySQL("Server = localhost; Port = 3306; Database = trailerfix; User = root; Password = MySql");

        //    //"Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=LaPaulitaDB;Integrated Security=SSPI;"
        //}

        // DbSet define propiedades para acceder a las tablas en la base de datos.
        public DbSet<Usuario> Usuarios { get; set; } // Tabla de usuarios.
        

        // Este método se llama al configurar el modelo de base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica configuraciones de entidades desde el ensamblado actual.
            modelBuilder.Entity<Usuario>().ToTable("usuarios");
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
            
        }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    
}

