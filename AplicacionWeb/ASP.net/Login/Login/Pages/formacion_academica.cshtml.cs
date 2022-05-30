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

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;

            cmd.CommandText = "Insert into FormacionAcademica (idAplicante,Institucion,Carrera,Pais,Estado,Ciudad,MesInicioFormacion,AnioInicioFormacion, MesFinalFormacion,AnioFinalFormacion) VALUES (" + idUsuario + ", '" + Institucion + "', '" + Carrera + "', '" + Pais + "', '" + Estado + "', '" + Ciudad + "', " + MesInicioFormacion + ", " + AnioInicioFormacion + ", " + MesFinalFormacion + ", '" + AnioFinalFormacion + "')";

            cmd.ExecuteNonQuery();
            conexion.Close();

            Response.Redirect("Idiomas");
        }

    }
}
