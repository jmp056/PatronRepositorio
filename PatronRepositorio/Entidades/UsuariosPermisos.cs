using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class UsuariosPermisos
    {
        [Key]
        public int UsuarioId { get; set; }
        public int PermisoId { get; set; }

        public UsuariosPermisos()
        {
            UsuarioId = 0;
            PermisoId = 0;
        }
    }
}
