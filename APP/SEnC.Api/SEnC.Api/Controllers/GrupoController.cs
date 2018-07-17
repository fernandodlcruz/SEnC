using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEnC.Business;
using SEnC.Datatypes;

namespace SEnC.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class GrupoController : ApiController
    {
        GrupoBusiness bus = new GrupoBusiness();

        // GET api/grupo
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetAll());
        }

        // GET api/usuario/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetById(id));
        }

        // POST api/grupo
        public HttpResponseMessage Post(Grupo grupo)
        {
            if (grupo == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Add(grupo);
                return Request.CreateResponse(HttpStatusCode.OK, grupo);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir grupo");
            }
        }

        // PUT api/grupo/5
        public HttpResponseMessage Put(Grupo grupo)
        {
            if (grupo == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Update(grupo);
                return Request.CreateResponse(HttpStatusCode.OK, grupo);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao atualizar grupo");
            }
        }

        // DELETE api/grupo/5
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Remove(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Grupo excluido");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir grupo");
            }
        }
    }
}
