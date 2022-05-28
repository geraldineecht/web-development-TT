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

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos2;Uid=root;password=Gato1415*;";
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
