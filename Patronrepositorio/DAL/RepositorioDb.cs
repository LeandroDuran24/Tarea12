using System.Data.Entity;
using Patronrepositorio.Entidades;

namespace PatronRepositorio.DAL
{
    public  class RepositorioDb :DbContext
    {
        public RepositorioDb():base("ConStr")
        {

        }
        public DbSet <UsuariosEntidades>user { get; set; }
        public DbSet<Categoria> categoria { get; set; }
    }
}
