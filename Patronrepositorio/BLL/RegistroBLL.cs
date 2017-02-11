using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using Patronrepositorio.Entidades;
using PatronRepositorio.DAL;

namespace PatronRepositoio.BLL
{
    public class RegistroBLL
    {

        public static bool Guardar(UsuariosEntidades nuevo)
        {
            bool retorno = false;
            using (var repositorio = new Repositorio<UsuariosEntidades>())
             {
                 retorno = repositorio.Guardar(nuevo) != null;
             }
             return retorno;
        }

    }
}
