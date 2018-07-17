using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SEnC.Business;
using SEnC.Datatypes;

namespace SEnC.Api.Controllers
{
    [RoutePrefix("api/v1/public")]
    public class UsuarioController : ApiController
    {
        UsuarioBusiness bus = new UsuarioBusiness();

        // GET api/usuario
        //[Route("usuarios")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetAll()); //new string[] { "value1", "value2" };
        }

        // GET api/usuario/5
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetById(id));
        }

        // GET api/usuario/aaa@aaa.com
        public HttpResponseMessage Get(string eMail)
        {
            return Request.CreateResponse(HttpStatusCode.OK, bus.GetByMail(eMail));
        }

        // POST api/usuario
        //public void Post([FromBody]string value)
        //{
        //}
        public HttpResponseMessage Post(Usuario usuario)
        {
            if (usuario == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Add(usuario);
                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao incluir usuario");
            }
        }

        // PUT api/usuario/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}
        public HttpResponseMessage Put(Usuario usuario)
        {
            if (usuario == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Update(usuario);
                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao atualizar usuario");
            }
        }

        // DELETE api/usuario/5
        //public void Delete(int id)
        //{
        //}
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest);

            try
            {
                bus.Remove(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Usuario excluido");
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Falha ao excluir usuario");
            }
        }
    }
}
