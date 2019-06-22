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
    public class CategoriasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Categorias> repositorio;
            repositorio = new RepositorioBase<Categorias>();
            Categorias categoria = new Categorias();
            categoria.CategoriaId = 1;
            categoria.NombreCategoria = "Categoria 1";
            categoria.Descripcion = "Primera Categoria";
            Assert.IsTrue(repositorio.Guardar(categoria));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Categorias> repositorio;
            repositorio = new RepositorioBase<Categorias>();
            Categorias categoria = new Categorias();
            categoria.CategoriaId = 1;
            categoria.NombreCategoria = "Categoria 1";
            categoria.Descripcion = "1era Categoria";
            Assert.IsTrue(repositorio.Modificar(categoria));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Categorias> repositorio;
            repositorio = new RepositorioBase<Categorias>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Categorias> repositorio;
            repositorio = new RepositorioBase<Categorias>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Categorias> repositorio;
            repositorio = new RepositorioBase<Categorias>();
            List<Categorias> lista = new List<Categorias>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}