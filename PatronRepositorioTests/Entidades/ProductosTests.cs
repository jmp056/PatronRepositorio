using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class ProductosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Productos> repositorio;
            repositorio = new RepositorioBase<Productos>();
            Productos producto = new Productos();
            producto.ProductoId = 1;
            producto.Nombre = "Maiz La Famosa";
            producto.Descripcion = "Lata de 100 mg";
            producto.FechaFabricacion = DateTime.Now;
            producto.CostoCompra = 1;
            producto.Stock = 1;
            producto.UnidadMedidaId = 1;
            producto.ImagenId = 1;
            producto.CategoriaId = 0;
            producto.MarcaId = 1;
            producto.ModeloId = 1;
            Assert.IsTrue(repositorio.Guardar(producto));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Productos> repositorio;
            repositorio = new RepositorioBase<Productos>();
            Productos producto = new Productos();
            producto.ProductoId = 1;
            producto.Nombre = "Maiz La Famosa";
            producto.Descripcion = "Lata de 100 mg";
            producto.FechaFabricacion = DateTime.Now;
            producto.CostoCompra = 1;
            producto.Stock = 1;
            producto.UnidadMedidaId = 2;
            producto.ImagenId = 1;
            producto.CategoriaId = 0;
            producto.MarcaId = 1;
            producto.ModeloId = 1;
            Assert.IsTrue(repositorio.Modificar(producto));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Productos> repositorio;
            repositorio = new RepositorioBase<Productos>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Productos> repositorio;
            repositorio = new RepositorioBase<Productos>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Productos> repositorio;
            repositorio = new RepositorioBase<Productos>();
            List<Productos> lista = new List<Productos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}