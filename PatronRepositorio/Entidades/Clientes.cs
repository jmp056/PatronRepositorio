﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public int PersonaId { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            PersonaId = 0;
        }
    }
}