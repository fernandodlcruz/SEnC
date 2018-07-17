using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class PeriodicidadeDao
    {
        public void Add(Periodicidade vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Periodicidade> repo = new EntityRepository<Periodicidade>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Periodicidade vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Periodicidade> repo = new EntityRepository<Periodicidade>(ctx))
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
                using (EntityRepository<Periodicidade> repo = new EntityRepository<Periodicidade>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Periodicidade Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Periodicidade> repo = new EntityRepository<Periodicidade>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Periodicidade> repo = new EntityRepository<Periodicidade>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
