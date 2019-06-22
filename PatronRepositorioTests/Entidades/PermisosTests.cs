using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class PermisosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Permisos> repositorio;
            repositorio = new RepositorioBase<Permisos>();
            Permisos permiso = new Permisos();
            permiso.PermisoId = 1;
            permiso.Descripcion = "Permiso 1";
            permiso.Funcionalidad = "Permiso minimo";
            Assert.IsTrue(repositorio.Guardar(permiso));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Permisos> repositorio;
            repositorio = new RepositorioBase<Permisos>();
            Permisos permiso = new Permisos();
            permiso.PermisoId = 1;
            permiso.Descripcion = "Permiso 1";
            permiso.Funcionalidad = "Permiso bajo";
            Assert.IsTrue(repositorio.Modificar(permiso));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Permisos> repositorio;
            repositorio = new RepositorioBase<Permisos>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Permisos> repositorio;
            repositorio = new RepositorioBase<Permisos>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Permisos> repositorio;
            repositorio = new RepositorioBase<Permisos>();
            List<Permisos> lista = new List<Permisos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}