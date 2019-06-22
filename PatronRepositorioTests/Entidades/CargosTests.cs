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
    public class CargosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Cargos cargo = new Cargos();
            cargo.CargoId = 2;
            cargo.NombreCargo = "Cargo 2";
            cargo.EstadoId = 2;
            Assert.IsTrue(repositorio.Guardar(cargo));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Cargos> repositorio;
            repositorio = new RepositorioBase<Cargos>();
            Cargos cargo = new Cargos();
            cargo.CargoId = 2;
            cargo.NombreCargo = "Cargo 1A";
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
            Assert.IsNotNull(repositorio.Buscar(2));
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