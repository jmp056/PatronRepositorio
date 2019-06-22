using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronRepositorio.Entidades
{
    public class UsuariosPermisos
    {
        [Key]
        public int UsuarioId { get; set; }
        public int PermisoId { get; set; }

        public UsuariosPermisos()
        {
            UsuarioId = 0;
            PermisoId = 0;
        }
    }
}
