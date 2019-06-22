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
    public class EmpleadosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Empleados> repositorio;
            repositorio = new RepositorioBase<Empleados>();
            Empleados empleado = new Empleados();
            empleado.EmpleadoId = 1;
            empleado.EstadoId = 0;
            empleado.CargoId = 1;
            empleado.PersonaId = 1;
            Assert.IsTrue(repositorio.Guardar(empleado));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Empleados> repositorio;
            repositorio = new RepositorioBase<Empleados>();
            Empleados empleado = new Empleados();
            empleado.EmpleadoId = 1;
            empleado.EstadoId = 1;
            empleado.CargoId = 1;
            empleado.PersonaId = 1;
            Assert.IsTrue(repositorio.Modificar(empleado));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Empleados> repositorio;
            repositorio = new RepositorioBase<Empleados>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Empleados> repositorio;
            repositorio = new RepositorioBase<Empleados>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Empleados> repositorio;
            repositorio = new RepositorioBase<Empleados>();
            List<Empleados> lista = new List<Empleados>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}