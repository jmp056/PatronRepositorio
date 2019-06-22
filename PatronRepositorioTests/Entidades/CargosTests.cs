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
            cargo.CargoId = 1;
            cargo.NombreCargo = "Cargo 1";
            cargo.EstadoId = 1;
            Assert.IsTrue(repositorio.Guardar(cargo));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Personas persona = new Personas();
            persona.PersonaId = 1;
            persona.DNI = 0;
            persona.Nombre = "Juan Perez";
            persona.Materno = "Juana Perez";
            persona.Paterno = "Ms. Juan Perez";
            persona.FechaNacimiento = DateTime.Now;
            persona.Telefono = "000-000-0000";
            persona.Correo = "JuanPerez123@hotmail.com";
            persona.Sexo = 'M';
            persona.Direccion = "San Francisco de Macoris";
            Assert.IsTrue(repositorio.Modificar(persona));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            Assert.IsNotNull(repositorio.Buscar(5));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Personas> repositorio;
            repositorio = new RepositorioBase<Personas>();
            List<Personas> lista = new List<Personas>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}