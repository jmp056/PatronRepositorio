using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class MarcasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Marcas> repositorio;
            repositorio = new RepositorioBase<Marcas>();
            Marcas marca = new Marcas();
            marca.MarcaId = 1;
            marca.NombreMarca = "La Famosa";
            Assert.IsTrue(repositorio.Guardar(marca));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Marcas> repositorio;
            repositorio = new RepositorioBase<Marcas>();
            Marcas marca = new Marcas();
            marca.MarcaId = 1;
            marca.NombreMarca = "La Famosa, CLaro";
            Assert.IsTrue(repositorio.Modificar(marca));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Marcas> repositorio;
            repositorio = new RepositorioBase<Marcas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Marcas> repositorio;
            repositorio = new RepositorioBase<Marcas>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Marcas> repositorio;
            repositorio = new RepositorioBase<Marcas>();
            List<Marcas> lista = new List<Marcas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}