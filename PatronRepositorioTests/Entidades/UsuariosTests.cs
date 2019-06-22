using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class UsuariosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = 1;
            usuario.EmpleadoId = 1;
            usuario.NombreUsuario = "JuanPerez";
            usuario.Clave = "JuanPerez123";
            Assert.IsTrue(repositorio.Guardar(usuario));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = 1;
            usuario.EmpleadoId = 1;
            usuario.NombreUsuario = "JuanPerez";
            usuario.Clave = "JuanPerez321";
            Assert.IsTrue(repositorio.Modificar(usuario));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Usuarios> repositorio;
            repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> lista = new List<Usuarios>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}