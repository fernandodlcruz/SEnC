using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;

namespace SEnC.Repository.Dao
{
    public class FornecedorDao
    {
        public void Add(Fornecedor vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Fornecedor> repo = new EntityRepository<Fornecedor>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Fornecedor vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Fornecedor> repo = new EntityRepository<Fornecedor>(ctx))
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
                using (EntityRepository<Fornecedor> repo = new EntityRepository<Fornecedor>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Fornecedor Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Fornecedor> repo = new EntityRepository<Fornecedor>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public System.Collections.IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Fornecedor> repo = new EntityRepository<Fornecedor>(ctx))
                {
                    return repo.GetAll();
                }
            }
        }
    }
}
