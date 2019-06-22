using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class TiposPersonas
    {
        [Key]
        public int TipoPersonaId { get; set; }
        public string Nombre { get; set; }

        public TiposPersonas()
        {
            TipoPersonaId = 0;
            Nombre = string.Empty;
        }
    }
}
