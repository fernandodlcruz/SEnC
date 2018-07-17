using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using System.Collections;

namespace SEnC.Repository
{
    public interface IRepository<E> : IDisposable where E : class, IDatatype
    {
        void Add(E entity);
 
        void Update(E entity);
 
        void Remove(int id);
 
        E Get(int id);
 
        IList GetAll();
 
        //IQueryable Query();
        IQueryable<E> Query(Func<E, bool> predicate);
 
        void Save();
    }
}
