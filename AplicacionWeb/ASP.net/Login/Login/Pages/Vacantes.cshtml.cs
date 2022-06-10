using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Atos.Pages
{
    public class VacantesModel : PageModel
    {
        public string NombreUsuario { get; set; }
        public int idUsuario { get; set; }
        [BindProperty]
        public string Perfil { get; set; }

        public string Msg { get; set; }



        private readonly IConfiguration _configuration;

        public VacantesModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            NombreUsuario = HttpContext.Session.GetString("username");

        }

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;

            cmd.CommandText = "Insert into Vacante (idAplicante,idPerfil) Values (" + idUsuario + ", (SELECT IdPerfil FROM Perfil WHERE TipoPerfil = '" + Perfil + "' ))";


            cmd.ExecuteNonQuery();


            conexion.Close();
            Response.Redirect("Informacion_personal");
        }
        public void OnPostPick()
        {

            HttpContext.Session.SetString("Perfil", Perfil);

            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;

            cmd.CommandText = "Insert into Vacante (idAplicante,idPerfil) Values (" + idUsuario + ", (SELECT IdPerfil FROM Perfil WHERE TipoPerfil = '" + Perfil + "' ))";


            cmd.ExecuteNonQuery();


            conexion.Close();
            Response.Redirect("Informacion_personal");
        }

        

    }
}