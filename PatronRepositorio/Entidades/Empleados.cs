﻿using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public int EstadoId { get; set; }
        public int CargoId { get; set; }
        public int PersonaId { get; set; }

        public Empleados()
        {
            EmpleadoId = 0;
            EstadoId = 0;
            CargoId = 0;
            PersonaId = 0;
        }
    }
}
