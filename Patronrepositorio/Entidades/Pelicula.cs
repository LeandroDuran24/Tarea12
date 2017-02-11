using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Patronrepositorio.Entidades
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId { get; set; }
        public DateTime FechaExtreno { get; set; }
        public string Descripcion { get; set; }
        public string CategoriaId { get; set; }

        public Pelicula()
        {

        }
        
    }
}
