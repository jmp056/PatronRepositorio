using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public int PersonaId { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            PersonaId = 0;
        }
    }
}
