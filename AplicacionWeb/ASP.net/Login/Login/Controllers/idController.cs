using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atos.Controllers
{
    [ApiController]
    [Route("api/idAplicante")]
    public class idController : ControllerBase
    {
        public int idUsuario { get; set; }

        [HttpGet]
        public object Get()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string allText = @"{ ""idUsuario"" : " + idUsuario.ToString() + "}";
            var jsonObject = JsonConvert.DeserializeObject<Aplicante>(allText);
            return jsonObject;
        }
       
    }

    public class Aplicante
    {
        public int idUsuario { get; set; }
    }
}


