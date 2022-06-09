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
    [Route("api/preguntas/DataEngineering")]

    public class DataEngineeringController : ControllerBase
    {
        [HttpGet]
        public object Get (int idUnity)
        {
            string allText = System.IO.File.ReadAllText("Preguntas.json");
            Root jsonObject = JsonConvert.DeserializeObject<Root>(allText);

            return jsonObject.Data_Engineering[idUnity];
         }
    }

    public class DataEngineering
    {
        public int id { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
    }

    public class Root
    {
        public List<DataEngineering> Data_Engineering { get; set; }
    }
}


