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
    public class formacion_academicaModel : PageModel
    {
        public int idUsuario { get; set; }
        [BindProperty]
        public string Institucion { get; set; }
        [BindProperty]
        public string Carrera { get; set; }
        [BindProperty]
        public string Pais { get; set; }
        [BindProperty]
        public string Estado { get; set; }
        [BindProperty]
        public string Ciudad { get; set; }
        [BindProperty]
        public int MesInicioFormacion { get; set; }
        [BindProperty]
        public int AnioInicioFormacion { get; set; }
        [BindProperty]
        public int MesFinalFormacion { get; set; }
        [BindProperty]
        public int AnioFinalFormacion { get; set; }

        private readonly IConfiguration _configuration;

        public formacion_academicaModel(IConfiguration configuration)
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

            if (MesFinalFormacion == 0 && AnioFinalFormacion == 0)
            {
                MesFinalFormacion = 6;
                AnioFinalFormacion = 2022;
            }

            cmd.CommandText = "Insert into FormacionAcademica (idAplicante,Institucion,Carrera,Pais,Estado,Ciudad,MesInicioFormacion,AnioInicioFormacion, MesFinalFormacion,AnioFinalFormacion) VALUES (" + idUsuario + ", '" + Institucion + "', '" + Carrera + "', '" + Pais + "', '" + Estado + "', '" + Ciudad + "', " + MesInicioFormacion + ", " + AnioInicioFormacion + ", " + MesFinalFormacion + ", '" + AnioFinalFormacion + "')";

            cmd.ExecuteNonQuery();
            conexion.Close();

            Response.Redirect("Idiomas");
        }

    }
}
