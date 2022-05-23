using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Login.Model;
using MySql.Data.MySqlClient;

namespace Atos.Pages
{
    public class Admin_viewModel : PageModel
    {
        public IList<Usuarios> ListaUsuarios { get; set; }

        public void OnPost()
        {

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos;Uid=root;password=;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexion;
            cmd.CommandText = "Select * from Aplicante";

            Usuarios usr1 = new Usuarios();
            ListaUsuarios = new List<Usuarios>();

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    usr1 = new Usuarios();
                    usr1.NombreUsuario = reader["Nombre"].ToString();
                    usr1.ApellidoPaterno = reader["ApellidoP"].ToString();
                    usr1.ApellidoMaterno = reader["ApellidoM"].ToString();
                    usr1.Correo = reader["Correo"].ToString();
                    ListaUsuarios.Add(usr1);
                }
            }
            conexion.Dispose();

        }

        public void OnGet()
        {
            ListaUsuarios = new List<Usuarios>();
        }
    }
}
