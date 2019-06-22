using System.ComponentModel.DataAnnotations;
namespace PatronRepositorio.Entidades
{
    public class Modelos
    {
        [Key]
        public int ModeloId { get; set; }
        public string NombreModelo { get; set; }
        public Modelos()
        {
            ModeloId = 0;
            NombreModelo = string.Empty;
        }
    }
}
