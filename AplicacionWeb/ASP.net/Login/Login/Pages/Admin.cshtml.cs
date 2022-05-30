using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Atos.Model;
using MySql.Data.MySqlClient;

namespace Login.Pages
{
    public class AdminModel : PageModel
    {

        public void OnPost(Admin adm)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = conexion;
            cmd.CommandText = " Select * from Administrador where Correo= '" + adm.Correo + "' and Contraseña= '" + adm.Contraseña + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conexion.Close();
                Response.Redirect("Admin_view");
            }
            else
            {
                conexion.Close();
                ViewData["Error"] = "Datos inválidos";
            }
        }
        private readonly ILogger<AdminModel> _logger;

        public AdminModel(ILogger<AdminModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}