using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class FornecedorBusiness
    {
        private FornecedorDao _dao = new FornecedorDao();

        public void Add(Fornecedor vo)
        {
            _dao.Add(vo);
        }

        public void Update(Fornecedor vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Fornecedor Get(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
