using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using PatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class DetallesVentasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<DetallesVentas> repositorio;
            repositorio = new RepositorioBase<DetallesVentas>();
            DetallesVentas detalleVenta = new DetallesVentas();
            detalleVenta.DetalleVentaId = 1;
            detalleVenta.VentaId = 1;
            detalleVenta.ProductoId = 1;
            detalleVenta.Unidades = 1;
            detalleVenta.CostoUnidad = 1;
            detalleVenta.DescuentoUnidad = 0;
            detalleVenta.Total = detalleVenta.Unidades * detalleVenta.CostoUnidad - detalleVenta.DescuentoUnidad;
            Assert.IsTrue(repositorio.Guardar(detalleVenta));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<DetallesVentas> repositorio;
            repositorio = new RepositorioBase<DetallesVentas>();
            DetallesVentas detalleVenta = new DetallesVentas();
            detalleVenta.DetalleVentaId = 1;
            detalleVenta.VentaId = 1;
            detalleVenta.ProductoId = 1;
            detalleVenta.Unidades = 2;
            detalleVenta.CostoUnidad = 1;
            detalleVenta.DescuentoUnidad = 0;
            detalleVenta.Total = detalleVenta.Unidades * detalleVenta.CostoUnidad - detalleVenta.DescuentoUnidad;
            Assert.IsTrue(repositorio.Modificar(detalleVenta));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<DetallesVentas> repositorio;
            repositorio = new RepositorioBase<DetallesVentas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<DetallesVentas> repositorio;
            repositorio = new RepositorioBase<DetallesVentas>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<DetallesVentas> repositorio;
            repositorio = new RepositorioBase<DetallesVentas>();
            List<DetallesVentas> lista = new List<DetallesVentas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}