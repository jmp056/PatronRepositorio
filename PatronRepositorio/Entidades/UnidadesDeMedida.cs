using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class UnidadesDeMedida
    {
        [Key]
        public int UnidadDeMedidaId { get; set; }
        public string NombreUnidadDeMedida { get; set; }

        public UnidadesDeMedida()
        {
            UnidadDeMedidaId = 0;
            NombreUnidadDeMedida = string.Empty;
        }
    }
}
