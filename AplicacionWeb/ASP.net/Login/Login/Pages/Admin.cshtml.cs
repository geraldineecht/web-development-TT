using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Atos.Model;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace Login.Pages
{
    public class AdminModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public AdminModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnPost(Admin Adm)
        {
            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = conexion;
            cmd.CommandText = " Select * from Administrador where Correo= '" + Adm.Correo + "' and Contraseña= '" + Adm.Contraseña + "'";
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

    }
}