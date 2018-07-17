using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class AlertaBusiness
    {
        private AlertaDao _dao = new AlertaDao();

        public void Add(Alerta vo)
        {
            _dao.Add(vo);
        }

        public void Update(Alerta vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Alerta Get(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
