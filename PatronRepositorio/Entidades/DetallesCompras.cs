using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class DetallesCompras
    {
        [Key]
        public int DetalleCompraId { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public double Unidades { get; set; }
        public double CostoUnidad { get; set; }
        public double Total { get; set; }

        public DetallesCompras()
        {
            DetalleCompraId = 0;
            CompraId = 0;
            ProductoId = 0;
            Unidades = 0;
            CostoUnidad = 0;
            Total = 0;
        }
    }
}
