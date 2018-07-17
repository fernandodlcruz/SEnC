using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEnC.Business;
using SEnC.Datatypes;

namespace SEnC.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class StatusController : ApiController
    {
        StatusBusiness bus = new StatusBusiness();

        // GET api/status
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetAll());
        }

        // GET api/usuario/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetById(id));
        }

        // POST api/status
        public HttpResponseMessage Post(Status status)
        {
            if (status == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Add(status);
                return Request.CreateResponse(HttpStatusCode.OK, status);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir status");
            }
        }

        // PUT api/status/5
        public HttpResponseMessage Put(Status status)
        {
            if (status == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Update(status);
                return Request.CreateResponse(HttpStatusCode.OK, status);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao atualizar status");
            }
        }

        // DELETE api/status/5
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Remove(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Status excluido");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir status");
            }
        }
    }
}
