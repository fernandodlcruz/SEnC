using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class UsuarioDao
    {
        public void Add(Usuario vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Usuario vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
                {
                    repo.Update(vo);

                    repo.Save();
                }
            }
        }

        public void Remove(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Usuario Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public Usuario GetByMail(string eMail)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
                {
                    //(from usuario in ctx.Usuario 
                    //where usuario.Email.Equals(eMail) select usuario).SingleOrDefault<UsuarioVo>();

                    var user = repo.Query(u => u.EmailUsuario == eMail);

                    return user.SingleOrDefault<Usuario>();
                }
            }
        }

        //public bool Login(string eMail, string pwd)
        //{
        //    using (SEnCContext ctx = new SEnCContext())
        //    {
        //        using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
        //        {
        //            var user = repo.Query(u => u.EmailUsuario == eMail && u.PassUsuario == pwd);

        //            return user.SingleOrDefault<Usuario>() != null ? true : false;
        //        }
        //    }
        //}

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Usuario> repo = new EntityRepository<Usuario>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
