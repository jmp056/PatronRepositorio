using System;
using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int TipoComprobanteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public double IGV { get; set; }
        public double SubTotal { get; set; }
        public double CostoVenta { get; set; }

        public Ventas()
        {
            VentaId = 0;
            UsuarioId = 0;
            ClienteId = 0;
            TipoComprobanteId = 0;
            FechaVenta = DateTime.Now;
            IGV = 0;
            SubTotal = 0;
            CostoVenta = 0;
        }
    }
}
