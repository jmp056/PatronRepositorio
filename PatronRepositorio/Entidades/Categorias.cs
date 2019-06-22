using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            NombreCategoria = string.Empty;
            Descripcion = string.Empty;
        }
    }
}
