using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository.Dao;

namespace SEnC.Business
{
    public class ConfiguracaoContaBusiness
    {
        private ConfiguracaoContaDao _dao = new ConfiguracaoContaDao();

        public void Add(ConfiguracaoConta vo)
        {
            _dao.Add(vo);
        }

        public void Update(ConfiguracaoConta vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public ConfiguracaoConta GetById(int id)
        {
            return _dao.Get(id);
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
