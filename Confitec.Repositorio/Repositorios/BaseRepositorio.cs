using Confitec.Dominio.BaseRepositorio;
using Confitec.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Confitec.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ConfitecContext ConfitecContext;

        public BaseRepositorio(ConfitecContext confitecContext)
        {
            ConfitecContext = confitecContext;
        }

        public void Adicionar(TEntity entity)
        {
            ConfitecContext.Set<TEntity>().Add(entity);
            ConfitecContext.SaveChanges();

        }

        public void Atualizar(TEntity entity)
        {
            ConfitecContext.Set<TEntity>().Update(entity);
            ConfitecContext.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return ConfitecContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ConfitecContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            ConfitecContext.Remove(entity);
            ConfitecContext.SaveChanges();
        }

        public void Dispose()
        {
            ConfitecContext.Dispose();
        }
    }
}
