using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class ClientesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();
            cliente.ClienteId = 1;
            cliente.PersonaId = 0;
            Assert.IsTrue(repositorio.Guardar(cliente));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();
            cliente.ClienteId = 1;
            cliente.PersonaId = 1;
            Assert.IsTrue(repositorio.Modificar(cliente));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Clientes> repositorio;
            repositorio = new RepositorioBase<Clientes>();
            List<Clientes> lista = new List<Clientes>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}