using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class VentasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Ventas> repositorio;
            repositorio = new RepositorioBase<Ventas>();
            Ventas venta = new Ventas();
            venta.VentaId = 1;
            venta.UsuarioId = 1;
            venta.ClienteId = 1;
            venta.TipoComprobanteId = 1;
            venta.FechaVenta = DateTime.Now;
            venta.IGV = 1;
            venta.SubTotal = 1;
            venta.CostoVenta = 1;
            Assert.IsTrue(repositorio.Guardar(venta));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Ventas> repositorio;
            repositorio = new RepositorioBase<Ventas>();
            Ventas venta = new Ventas();
            venta.VentaId = 1;
            venta.UsuarioId = 1;
            venta.ClienteId = 1;
            venta.TipoComprobanteId = 1;
            venta.FechaVenta = DateTime.Now;
            venta.IGV = 1;
            venta.SubTotal = 1;
            venta.CostoVenta = 1.08;
            Assert.IsTrue(repositorio.Modificar(venta));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Ventas> repositorio;
            repositorio = new RepositorioBase<Ventas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Ventas> repositorio;
            repositorio = new RepositorioBase<Ventas>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Ventas> repositorio;
            repositorio = new RepositorioBase<Ventas>();
            List<Ventas> lista = new List<Ventas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}