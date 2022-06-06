using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atos.Controllers
{
    [ApiController]
    [Route("api/login")]

    public class LoginController : ControllerBase
    {
        public string NombreAplicante { get; set; }
        public string CorreoAplicante { get; set; }
        [HttpGet]
        public string Get(string nombreUnity, string correoUnity)
        {
            NombreAplicante = HttpContext.Session.GetString("username");
            CorreoAplicante = HttpContext.Session.GetString("Correo");

            return "Hola" + NombreAplicante + CorreoAplicante;
            //login/?nombre=Carmina&correo=xd@gmail.com
            //return nombre + correo;
        }
    }
}
