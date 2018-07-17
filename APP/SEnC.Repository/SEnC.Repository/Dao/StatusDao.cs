using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class StatusDao
    {
        public void Add(Status vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Status> repo = new EntityRepository<Status>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Status vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Status> repo = new EntityRepository<Status>(ctx))
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
                using (EntityRepository<Status> repo = new EntityRepository<Status>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Status Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Status> repo = new EntityRepository<Status>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Status> repo = new EntityRepository<Status>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
