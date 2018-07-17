using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class GrupoBusiness
    {
        private GrupoDao _dao = new GrupoDao();

        public void Add(Grupo vo)
        {
            _dao.Add(vo);
        }

        public void Update(Grupo vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Grupo GetById(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
