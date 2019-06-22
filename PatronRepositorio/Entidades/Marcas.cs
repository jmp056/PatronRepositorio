﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Marcas
    {
        [Key]
        public int MarcaId { get; set; }
        public string NombreMarca { get; set; }

        public Marcas()
        {
            MarcaId = 0;
            NombreMarca = string.Empty;
        }
    }
}
