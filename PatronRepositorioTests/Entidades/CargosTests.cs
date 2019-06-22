using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class CargosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Cargos cargo = new Cargos();
            cargo.CargoId = 1;
            cargo.NombreCargo = "Cargo";
            cargo.EstadoId = 2;
            Assert.IsTrue(repositorio.Guardar(cargo));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Cargos cargo = new Cargos();
            cargo.CargoId = 1;
            cargo.NombreCargo = "Cargo 1";
            cargo.EstadoId = 2;
            Assert.IsTrue(repositorio.Modificar(cargo));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            List<Cargos> lista = new List<Cargos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}