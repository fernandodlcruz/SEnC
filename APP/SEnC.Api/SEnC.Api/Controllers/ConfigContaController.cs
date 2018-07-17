using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEnC.Business;
using SEnC.Datatypes;

namespace SEnC.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class ConfigContaController : ApiController
    {
        ConfiguracaoContaBusiness bus = new ConfiguracaoContaBusiness();

        // GET api/configconta
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetAll());
        }

        // GET api/usuario/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetById(id));
        }

        // POST api/configconta
        public HttpResponseMessage Post(ConfiguracaoConta cfgConta)
        {
            if (cfgConta == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Add(cfgConta);
                return Request.CreateResponse(HttpStatusCode.OK, cfgConta);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir configuracao da conta");
            }
        }

        // PUT api/configconta/5
        public HttpResponseMessage Put(ConfiguracaoConta cfgConta)
        {
            if (cfgConta == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Update(cfgConta);
                return Request.CreateResponse(HttpStatusCode.OK, cfgConta);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao atualizar configuracao da conta");
            }
        }

        // DELETE api/configconta/5
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Remove(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Configuracao da conta excluida");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir configuracao da conta");
            }
        }
    }
}
