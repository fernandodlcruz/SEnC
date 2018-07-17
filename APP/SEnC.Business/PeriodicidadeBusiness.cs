using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class PeriodicidadeBusiness
    {
        private PeriodicidadeDao _dao = new PeriodicidadeDao();

        public void Add(Periodicidade vo)
        {
            _dao.Add(vo);
        }

        public void Update(Periodicidade vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Periodicidade Get(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
