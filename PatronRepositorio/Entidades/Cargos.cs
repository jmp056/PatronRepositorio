using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Cargos
    {
        [Key]
        public int CargoId { get; set; }
        public string NombreCargo { get; set; }
        public int EstadoId { get; set; }

        public Cargos()
        {
            CargoId = 0;
            NombreCargo = string.Empty;
            EstadoId = 0;
        }
    }
}
