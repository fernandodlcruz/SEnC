using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class AfiliadoDao
    {
        public void Add(Afiliado vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Afiliado> repo = new EntityRepository<Afiliado>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Afiliado vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Afiliado> repo = new EntityRepository<Afiliado>(ctx))
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
                using (EntityRepository<Afiliado> repo = new EntityRepository<Afiliado>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Afiliado Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Afiliado> repo = new EntityRepository<Afiliado>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Afiliado> repo = new EntityRepository<Afiliado>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
