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
    public class AdminModel : PageModel
    {

        public void OnPost(Usuarios acc)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            cmd.Connection = conexion;
            cmd.CommandText = " Select * from Administrador where Nombre= '" + acc.NombreUsuario + "  'and ApellidoP= '" + acc.ApellidoPaterno + "'  and ApellidoM= '" + acc.ApellidoMaterno + "'  and Correo= '" + acc.Correo + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                conexion.Close();

                Response.Redirect("Entraste");
            }
            else
            {
                conexion.Close();
                Response.Redirect("Admin");
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