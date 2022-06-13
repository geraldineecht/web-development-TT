using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atos.Controllers
{

    [ApiController]
    [Route("api/entrevista")]
    public class ApplicantScoreController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ApplicantScoreController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public void Post([FromQuery] int scoreEntrevista, int idUsuario)
        {
            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "INSERT INTO Entrevista(idAplicante, fecha, puntaje) VALUES (" + idUsuario + ", CURDATE()," + scoreEntrevista + ");";

            cmd.ExecuteNonQuery();
            conexion.Close();

        }

    }
}