using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Imagenes
    {
        [Key]
        public int ImagenId { get; set; }
        public string RutaImagen { get; set; }

        public Imagenes()
        {
            ImagenId = 0;
            RutaImagen = string.Empty;
        }
    }
}
