using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Patronrepositorio.Entidades
{
    public class UsuariosEntidades
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }

        public UsuariosEntidades()
        {

        }
    }
}
