﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PatronRepositorio.DAL
{
    public interface IRepository <TEntity>:IDisposable where TEntity : class
    {
        TEntity Guardar(TEntity nuevo);
        bool Eliminar(TEntity Id);
        TEntity Buscar(Expression<Func<TEntity, bool>> Id);

    }
}
