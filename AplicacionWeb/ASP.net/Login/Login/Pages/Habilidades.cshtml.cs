using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;

namespace Atos.Pages
{
    public class HabilidadesModel : PageModel
    {
        public int idUsuario { get; set; }
        public string Habilidad1 { get; set; }
        public string Habilidad2 { get; set; }
        public string Habilidad3 { get; set; }
        public string Habilidad4 { get; set; }
        public string Habilidad5 { get; set; }

        [BindProperty]
        public int PorcHabilidad1 { get; set; }
        [BindProperty]
        public int PorcHabilidad2 { get; set; }
        [BindProperty]
        public int PorcHabilidad3 { get; set; }
        [BindProperty]
        public int PorcHabilidad4 { get; set; }
        [BindProperty]
        public int PorcHabilidad5 { get; set; }

        public void OnGet()
        {
            Habilidad1 = HttpContext.Session.GetString("Habilidad1");
            Habilidad2 = HttpContext.Session.GetString("Habilidad2");
            Habilidad3 = HttpContext.Session.GetString("Habilidad3");
            Habilidad4 = HttpContext.Session.GetString("Habilidad4");
            Habilidad5 = HttpContext.Session.GetString("Habilidad5");
        }

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
            Habilidad1 = HttpContext.Session.GetString("Habilidad1");
            Habilidad2 = HttpContext.Session.GetString("Habilidad2");
            Habilidad3 = HttpContext.Session.GetString("Habilidad3");
            Habilidad4 = HttpContext.Session.GetString("Habilidad4");
            Habilidad5 = HttpContext.Session.GetString("Habilidad5");

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into Habilidades (idAplicante,Habilidad1,PorcHabilidad1,Habilidad2,PorcHabilidad2,Habilidad3,PorcHabilidad3,Habilidad4,PorcHabilidad4,Habilidad5,PorcHabilidad5) Values ( " + idUsuario + " , '" + Habilidad1 + "' ,"+ PorcHabilidad1 + ", '" + Habilidad2 + "' ," + PorcHabilidad2 + ", '" + Habilidad3 + "' ," + PorcHabilidad3 + ", '" + Habilidad4 + "' ," + PorcHabilidad4 + ", '" + Habilidad5 + "' ," + PorcHabilidad5 + ")";

            cmd.ExecuteNonQuery();
            conexion.Close();

            Response.Redirect("Experiencia_profesional");
        }
    }
}
