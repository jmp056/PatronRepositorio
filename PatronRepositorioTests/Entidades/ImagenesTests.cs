using Microsoft.VisualStudio.TestTools.UnitTesting;
using PatronRepositorio.BLL;
using System.Collections.Generic;

namespace PatronRepositorio.Entidades.Tests
{
    [TestClass()]
    public class ImagenesTests
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioBase<Imagenes> repositorio;
            repositorio = new RepositorioBase<Imagenes>();
            Imagenes imagen = new Imagenes();
            imagen.ImagenId = 1;
            imagen.RutaImagen = "C:/Users/JMP";
            Assert.IsTrue(repositorio.Guardar(imagen));
        }

        [TestMethod()]
        public void Modificar()
        {
            RepositorioBase<Imagenes> repositorio;
            repositorio = new RepositorioBase<Imagenes>();
            Imagenes imagen = new Imagenes();
            imagen.ImagenId = 1;
            imagen.RutaImagen = "C:/Users/JMP/Escritorio";
            Assert.IsTrue(repositorio.Modificar(imagen));
        }

        [TestMethod()]
        public void Eliminar()
        {
            RepositorioBase<Imagenes> repositorio;
            repositorio = new RepositorioBase<Imagenes>();
            Assert.IsTrue(repositorio.Eliminar(1));
        }

        [TestMethod()]
        public void Buscar()
        {
            RepositorioBase<Imagenes> repositorio;
            repositorio = new RepositorioBase<Imagenes>();
            Assert.IsNotNull(repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetList()
        {
            RepositorioBase<Imagenes> repositorio;
            repositorio = new RepositorioBase<Imagenes>();
            List<Imagenes> lista = new List<Imagenes>();
            lista = repositorio.GetList(p => true);
            Assert.IsNotNull(lista);
        }
    }
}