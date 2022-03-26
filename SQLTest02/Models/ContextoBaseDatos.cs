using Microsoft.EntityFrameworkCore;

namespace SQLTest02.Models
{
    //1.- Aplicar herencia con DbContext
    public class ContextoBaseDatos : DbContext
    {
        //2.- Preparar al constructor para inyección
        //de dependencias
        public ContextoBaseDatos(DbContextOptions<ContextoBaseDatos> opt)
            : base(opt) { }
        //base indica que se llama al constructor de la clase base

        //3.- Indicamos las propiedades para realizar la migración
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Estado> Estados { get; set; }
    }
}
