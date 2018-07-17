using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class PagamentoDao
    {
        public void Add(Pagamento vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Pagamento> repo = new EntityRepository<Pagamento>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Pagamento vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Pagamento> repo = new EntityRepository<Pagamento>(ctx))
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
                using (EntityRepository<Pagamento> repo = new EntityRepository<Pagamento>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Pagamento Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Pagamento> repo = new EntityRepository<Pagamento>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Pagamento> repo = new EntityRepository<Pagamento>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
