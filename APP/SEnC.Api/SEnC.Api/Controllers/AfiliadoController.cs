using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEnC.Business;
using SEnC.Datatypes;

namespace SEnC.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class AfiliadoController : ApiController
    {
        AfiliadoBusiness bus = new AfiliadoBusiness();

        // GET api/afiliado
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetAll()); //new string[] { "value1", "value2" };
        }

        // GET api/usuario/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetById(id));
        }

        // POST api/afiliado
        public HttpResponseMessage Post(Afiliado afiliado)
        {
            if (afiliado == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Add(afiliado);
                return Request.CreateResponse(HttpStatusCode.OK, afiliado);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir afiliado");
            }
        }

        // PUT api/afiliado/5
        public HttpResponseMessage Put(Afiliado afiliado)
        {
            if (afiliado == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Update(afiliado);
                return Request.CreateResponse(HttpStatusCode.OK, afiliado);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao atualizar afiliado");
            }
        }

        // DELETE api/afiliado/5
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Remove(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Afiliado excluido");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir afiliado");
            }
        }
    }
}
