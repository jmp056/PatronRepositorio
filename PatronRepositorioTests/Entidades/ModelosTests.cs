using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class ModelosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Modelos> repositorio;
            repositorio = new RepositorioBase<Modelos>();
            Modelos modelo = new Modelos();
            modelo.ModeloId = 1;
            modelo.NombreModelo = "Juana";
            Assert.IsTrue(repositorio.Guardar(modelo));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Modelos> repositorio;
            repositorio = new RepositorioBase<Modelos>();
            Modelos modelo = new Modelos();
            modelo.ModeloId = 1;
            modelo.NombreModelo = "Juana Perez";
            Assert.IsTrue(repositorio.Modificar(modelo));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Modelos> repositorio;
            repositorio = new RepositorioBase<Modelos>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Modelos> repositorio;
            repositorio = new RepositorioBase<Modelos>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Modelos> repositorio;
            repositorio = new RepositorioBase<Modelos>();
            List<Modelos> lista = new List<Modelos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}