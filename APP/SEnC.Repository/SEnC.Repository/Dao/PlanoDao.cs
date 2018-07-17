using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class PlanoDao
    {
        public void Add(Plano vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Plano> repo = new EntityRepository<Plano>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Plano vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Plano> repo = new EntityRepository<Plano>(ctx))
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
                using (EntityRepository<Plano> repo = new EntityRepository<Plano>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Plano Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Plano> repo = new EntityRepository<Plano>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Plano> repo = new EntityRepository<Plano>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
