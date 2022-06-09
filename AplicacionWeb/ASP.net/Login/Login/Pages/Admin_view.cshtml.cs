using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Login.Model;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace Atos.Pages
{
    public class Admin_viewModel : PageModel

    {
        private readonly IConfiguration _configuration;

        public Admin_viewModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IList<Usuarios> ListaUsuarios { get; set; }

        public void OnPost()
        {

            

        }

        public void OnGet()
        {
            ListaUsuarios = new List<Usuarios>();

            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();

            cmd.Connection = conexion;
            cmd.CommandText = "SELECT u.idAplicante, a.Nombre, a.ApellidoP, a.ApellidoM , r.TipoPerfil FROM infopersonal u  JOIN  perfil r ON u.idPerfil = r.idPerfil JOIN aplicante a ON a.idAplicante = u.idAplicante group by idAplicante";

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
                    usr1.TipoPerfil = reader["TipoPerfil"].ToString();
                    usr1.idUser = reader["idAplicante"].GetHashCode();
                    ListaUsuarios.Add(usr1);
                }
            }
            conexion.Dispose();
        }


    }
}
