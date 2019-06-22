using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Proveedores
    {
        [Key]
        public int ProveedorId { get; set; }
        public int PersonaId { get; set; }

        public Proveedores()
        {
            ProveedorId = 0;
            PersonaId = 0;
        }
    }
}
