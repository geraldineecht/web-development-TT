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
        
      
        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
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
