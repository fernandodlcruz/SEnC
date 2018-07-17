using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;
using SEnC.Repository.Dao;
using System.Web.Security;

namespace SEnC.Business
{
    public class UsuarioBusiness
    {
        private UsuarioDao _dao = new UsuarioDao();

        public void Add(Usuario vo)
        {
            _dao.Add(vo);
        }

        public void Update(Usuario vo)
        {
            _dao.Update(vo);
        }

        public void Remove(int id)
        {
            _dao.Remove(id);
        }

        public Usuario GetById(int id)
        {
            return _dao.Get(id);
        }

        public Usuario GetByMail(string eMail)
        {
            return _dao.GetByMail(eMail);
        }

        public bool Login(string eMail, string pwd)
        {
            bool success = true; // = _dao.Login(eMail, pwd);

            Usuario user = _dao.GetByMail(eMail);

            // TODO: Validar a data de vigencia do plano do usuário
            //       e retornar as mensagens a partir deste método            

            if (DateTime.Compare(user.DataVigencia, DateTime.Now) < 0)
            {
                success = false;
            }

            return success;
        }

        public System.Collections.IList GetAll()
        {
            return _dao.GetAll();
        }
    }
}
