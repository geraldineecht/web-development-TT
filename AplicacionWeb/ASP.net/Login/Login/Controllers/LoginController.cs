using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net;



namespace Atos.Controllers
{
    [ApiController]
    [Route("api/login")]

    public class LoginController : ControllerBase
    {
        public string NombreAplicante { get; set; }
        public string CorreoAplicante { get; set; }

        [HttpGet]
        public HttpResponseMessage Get(string nombreUnity, string correoUnity)
        {
            NombreAplicante = HttpContext.Session.GetString("username");
            CorreoAplicante = HttpContext.Session.GetString("Correo");

            if (nombreUnity == NombreAplicante && correoUnity == CorreoAplicante)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }

        }
    }
}


// new random ().  