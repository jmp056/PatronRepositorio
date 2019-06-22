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
    public class TiposComprobantesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<TiposComprobantes> repositorio;
            repositorio = new RepositorioBase<TiposComprobantes>();
            TiposComprobantes tipoComprobante = new TiposComprobantes();
            tipoComprobante.TipoComprobanteId = 1;
            tipoComprobante.NombreComprobante = "Normal";
            Assert.IsTrue(repositorio.Guardar(tipoComprobante));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<TiposComprobantes> repositorio;
            repositorio = new RepositorioBase<TiposComprobantes>();
            TiposComprobantes tipoComprobante = new TiposComprobantes();
            tipoComprobante.TipoComprobanteId = 1;
            tipoComprobante.NombreComprobante = "Valor Fiscal";
            Assert.IsTrue(repositorio.Modificar(tipoComprobante));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<TiposComprobantes> repositorio;
            repositorio = new RepositorioBase<TiposComprobantes>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<TiposComprobantes> repositorio;
            repositorio = new RepositorioBase<TiposComprobantes>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<TiposComprobantes> repositorio;
            repositorio = new RepositorioBase<TiposComprobantes>();
            List<TiposComprobantes> lista = new List<TiposComprobantes>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}