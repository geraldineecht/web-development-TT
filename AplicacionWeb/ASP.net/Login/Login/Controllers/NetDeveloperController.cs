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
    [Route("api/preguntas/NetDeveloper")]

    public class NetDeveloperController : ControllerBase
    {
        [HttpGet]
        public object Get(int idUnity)
        {
            string allText = System.IO.File.ReadAllText("Preguntas.json");
            NetDeveloperRoot jsonObject = JsonConvert.DeserializeObject<NetDeveloperRoot>(allText);

            return jsonObject.NetDeveloper[idUnity];
        }
    }

    public class NetDeveloper
    {
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
    }

    public class NetDeveloperRoot
    {
        [JsonProperty(".Net_Developer")]
        public List<NetDeveloper> NetDeveloper { get; set; }
    }
}

