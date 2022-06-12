using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atos.Controllers
{
    [ApiController]
    [Route("api/entrevista/resultados")]


    public class ApplicantScoreController : ControllerBase
    {
        public int idUsuario { get; set; }
        public string scoreAplicante { get; set; }


        //// GET: api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        
        [HttpPost]
        //public void Post([FromBody] string value)
        public void Post([FromBody] int scoreEntrevista)
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "INSERT INTO entrevista(idAplicante, fecha, puntaje) VALUES (" + idUsuario + ", CURDATE(), " + scoreEntrevista + ");";

            cmd.ExecuteNonQuery();
            conexion.Close();


        }

    }
}
