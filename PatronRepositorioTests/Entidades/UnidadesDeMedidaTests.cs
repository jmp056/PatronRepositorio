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
    public class UnidadesDeMedidaTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<UnidadesDeMedida> repositorio;
            repositorio = new RepositorioBase<UnidadesDeMedida>();
            UnidadesDeMedida unidadDeMedida = new UnidadesDeMedida();
            unidadDeMedida.UnidadDeMedidaId = 1;
            unidadDeMedida.NombreUnidadDeMedida = "Peso";
            Assert.IsTrue(repositorio.Guardar(unidadDeMedida));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<UnidadesDeMedida> repositorio;
            repositorio = new RepositorioBase<UnidadesDeMedida>();
            UnidadesDeMedida unidadDeMedida = new UnidadesDeMedida();
            unidadDeMedida.UnidadDeMedidaId = 1;
            unidadDeMedida.NombreUnidadDeMedida = "Unidad";
            Assert.IsTrue(repositorio.Modificar(unidadDeMedida));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<UnidadesDeMedida> repositorio;
            repositorio = new RepositorioBase<UnidadesDeMedida>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<UnidadesDeMedida> repositorio;
            repositorio = new RepositorioBase<UnidadesDeMedida>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<UnidadesDeMedida> repositorio;
            repositorio = new RepositorioBase<UnidadesDeMedida>();
            List<UnidadesDeMedida> lista = new List<UnidadesDeMedida>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}