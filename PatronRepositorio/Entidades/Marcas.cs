using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Marcas
    {
        [Key]
        public int MarcaId { get; set; }
        public string NombreMarca { get; set; }

        public Marcas()
        {
            MarcaId = 0;
            NombreMarca = string.Empty;
        }
    }
}
