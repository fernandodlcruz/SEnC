using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class AlertaDao
    {
        public void Add(Alerta vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Alerta> repo = new EntityRepository<Alerta>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Alerta vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Alerta> repo = new EntityRepository<Alerta>(ctx))
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
                using (EntityRepository<Alerta> repo = new EntityRepository<Alerta>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Alerta Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Alerta> repo = new EntityRepository<Alerta>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Alerta> repo = new EntityRepository<Alerta>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
