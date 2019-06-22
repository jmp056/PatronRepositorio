using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class UsuariosPermisosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<UsuariosPermisos> repositorio;
            repositorio = new RepositorioBase<UsuariosPermisos>();
            UsuariosPermisos usuarioPermisos = new UsuariosPermisos();
            usuarioPermisos.UsuarioId = 1;
            usuarioPermisos.PermisoId = 0;
            Assert.IsTrue(repositorio.Guardar(usuarioPermisos));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<UsuariosPermisos> repositorio;
            repositorio = new RepositorioBase<UsuariosPermisos>();
            UsuariosPermisos usuarioPermisos = new UsuariosPermisos();
            usuarioPermisos.UsuarioId = 1;
            usuarioPermisos.PermisoId = 1;
            Assert.IsTrue(repositorio.Modificar(usuarioPermisos));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<UsuariosPermisos> repositorio;
            repositorio = new RepositorioBase<UsuariosPermisos>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<UsuariosPermisos> repositorio;
            repositorio = new RepositorioBase<UsuariosPermisos>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<UsuariosPermisos> repositorio;
            repositorio = new RepositorioBase<UsuariosPermisos>();
            List<UsuariosPermisos> lista = new List<UsuariosPermisos>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}