using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class TiposPersonasTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<TiposPersonas> repositorio;
            repositorio = new RepositorioBase<TiposPersonas>();
            TiposPersonas tipoPersona = new TiposPersonas();
            tipoPersona.TipoPersonaId = 1;
            tipoPersona.Nombre = "Normal";
            Assert.IsTrue(repositorio.Guardar(tipoPersona));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<TiposPersonas> repositorio;
            repositorio = new RepositorioBase<TiposPersonas>();
            TiposPersonas tipoPersona = new TiposPersonas();
            tipoPersona.TipoPersonaId = 1;
            tipoPersona.Nombre = "Temporal";
            Assert.IsTrue(repositorio.Modificar(tipoPersona));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<TiposPersonas> repositorio;
            repositorio = new RepositorioBase<TiposPersonas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<TiposPersonas> repositorio;
            repositorio = new RepositorioBase<TiposPersonas>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<TiposPersonas> repositorio;
            repositorio = new RepositorioBase<TiposPersonas>();
            List<TiposPersonas> lista = new List<TiposPersonas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}