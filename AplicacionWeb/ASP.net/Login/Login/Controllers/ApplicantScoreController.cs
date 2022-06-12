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
    [Route("api/entrevista")]
    public class ApplicantScoreController : ControllerBase
    {
        [HttpPost]
        //public void Post([FromBody] string value) [FromQuery] int scoreEntrevista
        public int Post([FromQuery] int scoreEntrevista, int idUsuario)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "INSERT INTO Entrevista(idAplicante, fecha, puntaje) VALUES (" + idUsuario + ", CURDATE()," + scoreEntrevista + ");";

            cmd.ExecuteNonQuery();
            conexion.Close();

            return scoreEntrevista + idUsuario;

        }

    }
}
