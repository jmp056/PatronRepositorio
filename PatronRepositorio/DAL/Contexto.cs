using PatronRepositorio.Entidades;
using System.Data.Entity;

namespace PatronRepositorio.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Compras> Compras { get; set; }
        public DbSet<DetallesCompras> DetallesCompras { get; set; }
        public DbSet<DetallesVentas> DetallesVentas { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<Imagenes> Imagenes { get; set; }
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Modelos> Modelos { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<TiposComprobantes> TiposComprobantes { get; set; }
        public DbSet<TiposPersonas> TiposPersonas { get; set; }
        public DbSet<UnidadesDeMedida> UnidadesDeMedida { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<UsuariosPermisos> UsuariosPermisos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
