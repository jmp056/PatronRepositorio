using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class DetallesVentas
    {
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double DescuentoUnidad { get; set; }
        public double Total { get; set; }

        public DetallesVentas()
        {
            DetalleVentaId = 0;
            VentaId = 0;
            ProductoId = 0;
            Unidades = 0;
            Costounidad = 0;
            DescuentoUnidad = 0;
            Total = 0;
        }
    }
}
