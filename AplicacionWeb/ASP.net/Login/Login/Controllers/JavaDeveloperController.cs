using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atos.Controllers
{
    [ApiController]
    [Route("api/preguntas/JavaDeveloper")]

    public class JavaDeveloperController : ControllerBase
    {
        [HttpGet]
        public object Get(int idUnity)
        {
            string allText = System.IO.File.ReadAllText("Preguntas.json");
            JavaDeveloperRoot jsonObject = JsonConvert.DeserializeObject<JavaDeveloperRoot>(allText);

            return jsonObject.Java_Developer[idUnity];
        }
    }

    public class JavaDeveloper
    {
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
    }

    public class JavaDeveloperRoot
    {
        public List<JavaDeveloper> Java_Developer { get; set; }
    }
}

