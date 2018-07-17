using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using System.Data.Entity;
using System.Data;
using System.Data.Objects;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

namespace SEnC.Repository
{
    public class EntityRepository<E> : IDisposable, IRepository<E> where E : class, IDatatype
    {
        private SEnCContext context;

        public EntityRepository(SEnCContext context)
        {
            this.context = context;
        }

        public void Add(E entity)
        {
            context.Set<E>().Add(entity);
        }

        public void Update(E entity)
        {
            context.Set<E>().Attach(entity);
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int id)
        {
            //context.Set<E>().Remove(entity);
            context.Set<E>().Remove(context.Set<E>().Find(id));
        }

        public E Get(int id)
        {
            return context.Set<E>().Find(id);
        }

        public System.Collections.IList GetAll()
        {
            return context.Set<E>().ToList();
        }

        public System.Collections.IList GetAll(Expression<Func<E, object>> selector)
        {
            return context.Set<E>().Include(selector).ToList();
        }
        public System.Collections.IList GetAll(string table)
        {
            return context.Set<E>().Include(table).ToList();
        }
        //https://www.thomaslevesque.com/2010/10/03/entity-framework-using-include-with-lambda-expressions/

        public IQueryable<E> Query(Func<E, bool> predicate)
        {
            //return context.Set<E>().AsQueryable();
            return context.Set<E>().Where(predicate).AsQueryable();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}