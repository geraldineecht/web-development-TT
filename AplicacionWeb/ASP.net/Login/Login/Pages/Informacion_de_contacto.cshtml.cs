using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Atos.Model;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Atos.Pages
{
    public class Informacion_de_contactoModel : PageModel
    {
        public int idUsuario { get; set; }
        [BindProperty]
        public string Telefono { get; set; }
        [BindProperty]
        public string Ciudad { get; set; }
        [BindProperty]
        public int CodigoPostal { get; set; }
        [BindProperty]
        public string Direccion { get; set; }

        private readonly IConfiguration _configuration;

        public Informacion_de_contactoModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into InfoContacto (idAplicante,Telefono,idCiudad,CP,Direccion) Values (" + idUsuario + ", '" + Telefono + "' , (SELECT idCiudad FROM Ciudad WHERE NombreCiudad = '" + Ciudad + "' )," + CodigoPostal + ", '" + Direccion + "')";
            cmd.ExecuteNonQuery();
            conexion.Close();


            Response.Redirect("Sobre_mi");

        }


    }
}