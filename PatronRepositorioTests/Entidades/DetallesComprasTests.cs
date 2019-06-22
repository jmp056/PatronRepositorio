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
    public class DetallesComprasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<DetallesCompras> repositorio;
            repositorio = new RepositorioBase<DetallesCompras>();
            DetallesCompras detalleCompra = new DetallesCompras();
            detalleCompra.DetalleCompraId = 1;
            detalleCompra.CompraId = 1;
            detalleCompra.ProductoId = 1;
            detalleCompra.Unidades = 1;
            detalleCompra.CostoUnidad = 1;
            detalleCompra.Total = detalleCompra.Unidades * detalleCompra.CostoUnidad;
            Assert.IsTrue(repositorio.Guardar(detalleCompra));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<DetallesCompras> repositorio;
            repositorio = new RepositorioBase<DetallesCompras>();
            DetallesCompras detalleCompra = new DetallesCompras();
            detalleCompra.DetalleCompraId = 1;
            detalleCompra.CompraId = 1;
            detalleCompra.ProductoId = 1;
            detalleCompra.Unidades = 2;
            detalleCompra.CostoUnidad = 1;
            detalleCompra.Total = detalleCompra.Unidades * detalleCompra.CostoUnidad;
            Assert.IsTrue(repositorio.Modificar(detalleCompra));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<DetallesCompras> repositorio;
            repositorio = new RepositorioBase<DetallesCompras>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<DetallesCompras> repositorio;
            repositorio = new RepositorioBase<DetallesCompras>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<DetallesCompras> repositorio;
            repositorio = new RepositorioBase<DetallesCompras>();
            List<DetallesCompras> lista = new List<DetallesCompras>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}