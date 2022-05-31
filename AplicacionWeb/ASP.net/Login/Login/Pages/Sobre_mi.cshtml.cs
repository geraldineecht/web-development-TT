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
        public string Habilidad2 { get; set; }
        [BindProperty]
        public string Habilidad3 { get; set; }
        [BindProperty]
        public string Habilidad4 { get; set; }
        [BindProperty]
        public string Habilidad5 { get; set; }
        

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into SobreMi(idAplicante,AcercaDeMi,Habilidad1,Habilidad2,Habilidad3,Habilidad4,Habilidad5) Values ( " + idUsuario + " , '" + AcercaDeMi + "' ,'" + Habilidad1 + "' ,'" + Habilidad2 + "' ,'" + Habilidad3 + "' ,'" + Habilidad4 + "' ,'" + Habilidad5   + "' )";
            cmd.ExecuteNonQuery();

            HttpContext.Session.SetString("Habilidad1", Habilidad1);
            HttpContext.Session.SetString("Habilidad2", Habilidad2);
            HttpContext.Session.SetString("Habilidad3", Habilidad3);
            HttpContext.Session.SetString("Habilidad4", Habilidad4);
            HttpContext.Session.SetString("Habilidad5", Habilidad5);


            conexion.Close();
            Response.Redirect("Habilidades");


        }

    }
}
