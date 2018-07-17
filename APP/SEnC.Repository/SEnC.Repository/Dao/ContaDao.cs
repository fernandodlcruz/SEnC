using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class ContaDao
    {
        public void Add(Conta vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Conta> repo = new EntityRepository<Conta>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Conta vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Conta> repo = new EntityRepository<Conta>(ctx))
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
                using (EntityRepository<Conta> repo = new EntityRepository<Conta>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Conta Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Conta> repo = new EntityRepository<Conta>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Conta> repo = new EntityRepository<Conta>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
