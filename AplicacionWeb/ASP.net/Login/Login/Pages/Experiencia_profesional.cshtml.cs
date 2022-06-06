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
    public class Experiencia_profesionalModel : PageModel
    {
        public int idUsuario { get; set; }

        [BindProperty]
        public string PuestoExperiencia { get; set; }
        [BindProperty]
        public string EmpresaExperiencia { get; set; }
        [BindProperty]
        public int MesExperiencia { get; set; }
        [BindProperty]
        public int AnioExperiencia { get; set; }
        [BindProperty]
        public int MesExperienciaFin { get; set; }
        [BindProperty]
        public int AnioExperienciaFin { get; set; }
        [BindProperty]
        public string Actividades { get; set; }

        private readonly IConfiguration _configuration;

        public Experiencia_profesionalModel(IConfiguration configuration)
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

            cmd.CommandText = "Insert into ExperienciaProfesional (idAplicante,PuestoExperiencia,EmpresaExperiencia,MesExperienciaInicio,AnioExperienciaInicio,MesExperienciaFin, AnioExperienciaFin,Actividades) VALUES (" + idUsuario + ", '" + PuestoExperiencia + "', '" + EmpresaExperiencia + "', " + MesExperiencia + ", " + AnioExperiencia + ", " + MesExperienciaFin + ", " + AnioExperienciaFin + ", '" + Actividades + "')";

            cmd.ExecuteNonQuery();
            conexion.Close();

            Response.Redirect("formacion_academica");

        }
    }
}
