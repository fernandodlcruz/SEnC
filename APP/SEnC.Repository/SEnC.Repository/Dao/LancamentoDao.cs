using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class LancamentoDao
    {
        public void Add(Lancamento vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Lancamento> repo = new EntityRepository<Lancamento>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Lancamento vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Lancamento> repo = new EntityRepository<Lancamento>(ctx))
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
                using (EntityRepository<Lancamento> repo = new EntityRepository<Lancamento>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Lancamento Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Lancamento> repo = new EntityRepository<Lancamento>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Lancamento> repo = new EntityRepository<Lancamento>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
