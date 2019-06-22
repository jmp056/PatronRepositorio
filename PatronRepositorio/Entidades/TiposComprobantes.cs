using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class TiposComprobantes
    {
        public int TipoComprobanteId { get; set; }
        public string NombreComprobante { get; set; }

        public TiposComprobantes()
        {
            TipoComprobanteId = 0;
            NombreComprobante = string.Empty;
        }
    }
}
