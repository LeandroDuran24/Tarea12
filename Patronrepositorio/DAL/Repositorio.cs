using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace PatronRepositorio.DAL
{
    public class Repositorio <TEntity> : IRepository <TEntity> where TEntity: class
    {
        RepositorioDb context = null;
        public Repositorio()
        {
            context = new RepositorioDb();
        }

        private DbSet<TEntity>EntitySet
        {
            get 
            {
                return context.Set<TEntity>();
            }
        }

        public TEntity Guardar(TEntity nuevo)
        {
            TEntity resultado = null;
            try
            {
                EntitySet.Add(nuevo);
                context.SaveChanges();
                resultado = nuevo;

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

       

        public TEntity Buscar(Expression<Func<TEntity, bool>> Id)
        {
            TEntity resultado = null;

            try
            {
                resultado = EntitySet.FirstOrDefault(Id);
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        public bool Eliminar(TEntity Id)
        {
            bool resultado = false;
            try
            {
                EntitySet.Attach(Id);
                EntitySet.Remove(Id);
                resultado = context.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

      
        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();

            }
        }
    }
}
