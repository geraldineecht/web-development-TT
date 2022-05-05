using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Login.Model;
using MySql.Data.MySqlClient;

namespace Login.Pages
{
    public class UserModel : PageModel
    {

        public void OnPost(Usuarios acc)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = " Insert into Aplicante(Nombre,ApellidoP,ApellidoM,Correo) Values ('" + acc.NombreUsuario + "  ','" + acc.ApellidoPaterno + "' , '" + acc.ApellidoMaterno + "' , '" + acc.Correo + "')";
            cmd.ExecuteNonQuery();
            Response.Redirect("informacion_personal");
        }
        private readonly ILogger<UserModel> _logger;

        public UserModel(ILogger<UserModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
