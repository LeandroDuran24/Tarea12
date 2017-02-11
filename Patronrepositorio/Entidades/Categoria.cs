using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Patronrepositorio.Entidades
{
    public class Categoria
    {   
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        public Categoria()
        {

        }
    }
}
