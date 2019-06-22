using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Materno { get; set; }
        public string Paterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public Char Sexo { get; set; }
        public int ImagenId { get; set; }
        public string Direccion { get; set; }
        public int TipoPersonaId { get; set; }

        public Personas()
        {
            PersonaId = 0;
            DNI = 0;
            Nombre = string.Empty;
            Materno = string.Empty;
            Paterno = string.Empty;
            FechaNacimiento = DateTime.Now;
            Telefono = string.Empty;
            Correo = string.Empty;
            Sexo = '\0';
            ImagenId = 0;
            Direccion = string.Empty;
            TipoPersonaId = 0;
        }
    }
}
