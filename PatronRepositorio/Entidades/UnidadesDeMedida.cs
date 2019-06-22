using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class UnidadesDeMedida
    {
        [Key]
        public int UnidadDeMedidaId { get; set; }
        public string NombreUnidadDeMedida { get; set; }

        public UnidadesDeMedida()
        {
            UnidadDeMedidaId = 0;
            NombreUnidadDeMedida = string.Empty;
        }
    }
}
