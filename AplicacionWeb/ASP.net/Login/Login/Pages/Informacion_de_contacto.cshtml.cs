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
        public int? idUsuario { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        public string Direccion { get; set; }

        public void OnGet()
        {
            idUsuario = HttpContext.Session.GetInt32("idUser");
        }

      
        public void OnPost()
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into InfoContacto (idAplicante,Telefono,idCiudad,CP,Direccion) Values (" + idUsuario + ", '" + Telefono + "' , (SELECT idCiudad FROM Ciudad WHERE NombreCiudad = '" + Ciudad + "' )," + CodigoPostal + ", '" + Direccion + "')";
            cmd.ExecuteNonQuery();
            conexion.Close();    
        }
    }
}
