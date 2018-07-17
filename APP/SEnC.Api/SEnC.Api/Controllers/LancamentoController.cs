using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEnC.Business;
using SEnC.Datatypes;

namespace SEnC.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class LancamentoController : ApiController
    {
        LancamentoBusiness bus = new LancamentoBusiness();

        // GET api/lancamento
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetAll());
        }

        // GET api/usuario/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetById(id));
        }

        // POST api/lancamento
        public HttpResponseMessage Post(Lancamento lanc)
        {
            if (lanc == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Add(lanc);
                return Request.CreateResponse(HttpStatusCode.OK, lanc);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir lancamento");
            }
        }

        // PUT api/lancamento/5
        public HttpResponseMessage Put(Lancamento lanc)
        {
            if (lanc == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Update(lanc);
                return Request.CreateResponse(HttpStatusCode.OK, lanc);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao atualizar lancamento");
            }
        }

        // DELETE api/lancamento/5
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Remove(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Lancamento excluido");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir lancamento");
            }
        }
    }
}
