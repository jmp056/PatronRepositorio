using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class ComprasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Compras> repositorio;
            repositorio = new RepositorioBase<Compras>();
            Compras compra = new Compras();
            compra.CompraId = 1;
            compra.UsuarioId = 1;
            compra.FechaCompra = DateTime.Now;
            compra.ProveedorId = 1;
            compra.TipoComprobanteId = 1;
            compra.CostoCompra = 0;
            Assert.IsTrue(repositorio.Guardar(compra));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Compras> repositorio;
            repositorio = new RepositorioBase<Compras>();
            Compras compra = new Compras();
            compra.CompraId = 1;
            compra.UsuarioId = 1;
            compra.FechaCompra = DateTime.Now;
            compra.ProveedorId = 1;
            compra.TipoComprobanteId = 1;
            compra.CostoCompra = 100;
            Assert.IsTrue(repositorio.Modificar(compra));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Compras> repositorio;
            repositorio = new RepositorioBase<Compras>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Compras> repositorio;
            repositorio = new RepositorioBase<Compras>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Compras> repositorio;
            repositorio = new RepositorioBase<Compras>();
            List<Compras> lista = new List<Compras>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}