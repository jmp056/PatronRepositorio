using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class EstadosTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Estados> repositorio;
            repositorio = new RepositorioBase<Estados>();
            Estados estado = new Estados();
            estado.EstadoId = 1;
            estado.FechaInicio = DateTime.Now;
            estado.FechaFin = DateTime.Now;
            estado.Estado = "Disponible";
            Assert.IsTrue(repositorio.Guardar(estado));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Estados> repositorio;
            repositorio = new RepositorioBase<Estados>();
            Estados estado = new Estados();
            estado.EstadoId = 1;
            estado.FechaInicio = DateTime.Now;
            estado.FechaFin = DateTime.Now;
            estado.Estado = "Ocupado";
            Assert.IsTrue(repositorio.Modificar(estado));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Estados> repositorio;
            repositorio = new RepositorioBase<Estados>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Estados> repositorio;
            repositorio = new RepositorioBase<Estados>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Estados> repositorio;
            repositorio = new RepositorioBase<Estados>();
            List<Estados> lista = new List<Estados>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}