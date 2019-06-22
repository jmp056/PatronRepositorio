using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class DetallesCompras
    {
        public int DetalleCompraId { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public double Unidades { get; set; }
        public double Costounidad { get; set; }
        public double Total { get; set; }

        public DetallesCompras()
        {
            DetalleCompraId = 0;
            CompraId = 0;
            ProductoId = 0;
            Unidades = 0;
            Costounidad = 0;
            Total = 0;
        }
    }
}
