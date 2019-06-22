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
    public class ProveedoresTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Proveedores> repositorio;
            repositorio = new RepositorioBase<Proveedores>();
            Proveedores proveedor = new Proveedores();
            proveedor.ProveedorId = 1;
            proveedor.PersonaId = 1;
            Assert.IsTrue(repositorio.Guardar(proveedor));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Proveedores> repositorio;
            repositorio = new RepositorioBase<Proveedores>();
            Proveedores proveedor = new Proveedores();
            proveedor.ProveedorId = 1;
            proveedor.PersonaId = 2;
            Assert.IsTrue(repositorio.Modificar(proveedor));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Proveedores> repositorio;
            repositorio = new RepositorioBase<Proveedores>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Proveedores> repositorio;
            repositorio = new RepositorioBase<Proveedores>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Proveedores> repositorio;
            repositorio = new RepositorioBase<Proveedores>();
            List<Proveedores> lista = new List<Proveedores>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}