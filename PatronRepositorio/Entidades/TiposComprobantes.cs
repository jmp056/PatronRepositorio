using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class TiposComprobantes
    {
        [Key]
        public int TipoComprobanteId { get; set; }
        public string NombreComprobante { get; set; }

        public TiposComprobantes()
        {
            TipoComprobanteId = 0;
            NombreComprobante = string.Empty;
        }
    }
}
