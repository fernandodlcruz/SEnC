using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class LancamentoBusiness
    {
        private LancamentoDao _dao = new LancamentoDao();

        public void Add(Lancamento vo)
        {
            _dao.Add(vo);
        }

        public void Update(Lancamento vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Lancamento GetById(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
