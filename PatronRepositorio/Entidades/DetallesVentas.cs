using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class DetallesVentas
    {
        [Key]
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double DescuentoUnidad { get; set; }
        public double Total { get; set; }

        public DetallesVentas()
        {
            DetalleVentaId = 0;
            VentaId = 0;
            ProductoId = 0;
            Unidades = 0;
            CostoUnidad = 0;
            DescuentoUnidad = 0;
            Total = 0;
        }
    }
}
