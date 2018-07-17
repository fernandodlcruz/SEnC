using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class ConfiguracaoContaDao
    {
        public void Add(ConfiguracaoConta vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<ConfiguracaoConta> repo = new EntityRepository<ConfiguracaoConta>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(ConfiguracaoConta vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<ConfiguracaoConta> repo = new EntityRepository<ConfiguracaoConta>(ctx))
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
                using (EntityRepository<ConfiguracaoConta> repo = new EntityRepository<ConfiguracaoConta>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public ConfiguracaoConta Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<ConfiguracaoConta> repo = new EntityRepository<ConfiguracaoConta>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<ConfiguracaoConta> repo = new EntityRepository<ConfiguracaoConta>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
