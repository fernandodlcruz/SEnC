using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class AfiliadoBusiness
    {
        private AfiliadoDao _dao = new AfiliadoDao();

        public void Add(Afiliado vo)
        {
            _dao.Add(vo);
        }

        public void Update(Afiliado vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Afiliado GetById(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
