using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEnC.Datatypes;
using SEnC.Repository;
using System.Collections;

namespace SEnC.Repository.Dao
{
    public class GrupoDao
    {
        public void Add(Grupo vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Grupo> repo = new EntityRepository<Grupo>(ctx))
                {
                    repo.Add(vo);

                    repo.Save();
                }
            }
        }

        public void Update(Grupo vo)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Grupo> repo = new EntityRepository<Grupo>(ctx))
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
                using (EntityRepository<Grupo> repo = new EntityRepository<Grupo>(ctx))
                {
                    repo.Remove(id);
                    repo.Save();
                }
            }
        }

        public Grupo Get(int id)
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Grupo> repo = new EntityRepository<Grupo>(ctx))
                {
                    return repo.Get(id);
                }
            }
        }

        public IList GetAll()
        {
            using (SEnCContext ctx = new SEnCContext())
            {
                using (EntityRepository<Grupo> repo = new EntityRepository<Grupo>(ctx))
                {
                    //var user = repo.Query(u => u.EmailUsuario == eMail);

                    //return user.SingleOrDefault<Usuario>();

                    //return repo.GetAll(g => g.Lancamentos);
                    //return repo.GetAll("Lancamentos");

                    //var parentQuery = ctx.Grupo.Select(p => new { Grupo = p, LancamentosCount = p.Lancamentos.Count() }).ToList();
                    //parentQuery.ForEach(p => p.Grupo.LancamentosCount = p.LancamentosCount);

                    var parentQuery = ctx.Grupo.Select(p => new
                    {
                        id = p.Id,
                        nome = p.Nome,
                        usuarioId = p.UsuarioId,
                        //usuario = p.Usuario,
                        idPai = p.IdPai,
                        //lancamentos = p.Lancamentos,
                        LancamentosCount = p.Lancamentos.Count()
                    }).OrderBy(p => p.idPai).ThenBy(p => p.id).ToList();

                    IList retList = new ArrayList();

                    for (int i = 0; i < parentQuery.Count()-1; i++)
                    {
                        if (parentQuery[i].idPai == 0)
                            retList.Add(parentQuery[i]);

                        for (int x = 1; x < parentQuery.Count(); x++)
                        {
                            if (parentQuery[x].idPai == parentQuery[i].id)
                                retList.Add(parentQuery[x]);
                        }

                    }

                    return retList; // parentQuery;
                }
            }
        }
    }
}
