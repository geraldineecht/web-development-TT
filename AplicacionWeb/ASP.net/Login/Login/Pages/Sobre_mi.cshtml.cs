using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;

namespace Atos.Pages
{
    public class Sobre_miModel : PageModel
    {
        public int idUsuario { get; set; }
        [BindProperty]
        public string AcercaDeMi { get; set; }
        [BindProperty]
        public string Habilidad1 { get; set; }
        [BindProperty]
        public int PorcHabilidad1 { get; set; }
        [BindProperty]
        public string Habilidad2 { get; set; }
        [BindProperty]
        public string Habilidad3 { get; set; }
        [BindProperty]
        public string Habilidad4 { get; set; }
        [BindProperty]
        public string Habilidad5 { get; set; }
        [BindProperty]
        public string Habilidad6 { get; set; }
        [BindProperty]
        public string Habilidad7 { get; set; }
        [BindProperty]
        public string Habilidad8 { get; set; }
        [BindProperty]
        public string Habilidad9 { get; set; }

        public string[] Skills = new string[5]{ "name1", "name2", "name3", "name4", "name5" };

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into SobreMi(idAplicante,AcercaDeMi,Habilidad,Porcentaje) Values ( " + idUsuario + " , '" + AcercaDeMi + "' ,'" + Habilidad1 + "' ," + PorcHabilidad1 + ")";
            cmd.ExecuteNonQuery();


            conexion.Close();
            Response.Redirect("Experiencia_profesional");


        }

    }
}
