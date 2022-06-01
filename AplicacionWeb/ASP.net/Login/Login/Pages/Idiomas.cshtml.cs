using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Atos.Pages
{
    public class IdiomasModel : PageModel
    {
        public int idUsuario { get; set; }
        [BindProperty]
        public string Idioma1 { get; set; }
        [BindProperty]
        public string Nivel1 { get; set; }
        [BindProperty]
        public string Idioma2 { get; set; }
        [BindProperty]
        public string Nivel2 { get; set; }
        [BindProperty]
        public string Idioma3 { get; set; }
        [BindProperty]
        public string Nivel3 { get; set; }
        [BindProperty]
        public string Idioma4 { get; set; }
        [BindProperty]
        public string Nivel4 { get; set; }
        [BindProperty]
        public string Idioma5 { get; set; }
        [BindProperty]
        public string Nivel5 { get; set; }
        [BindProperty]
        public string Idioma6 { get; set; }
        [BindProperty]
        public string Nivel6 { get; set; }

        private readonly IConfiguration _configuration;

        public IdiomasModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into Idiomas (idAplicante,Idioma,Nivel) Values ( " + idUsuario + " , '" + Idioma1 + "' ,  '" + Nivel1 + "' )";
            cmd.ExecuteNonQuery();

            if (!(string.IsNullOrEmpty(Idioma2)))
            {
                cmd.CommandText = "Insert into Idiomas (idAplicante,Idioma,Nivel) Values ( " + idUsuario + " , '" + Idioma2 + "' ,  '" + Nivel2 + "' )";
                cmd.ExecuteNonQuery();

                if (!(string.IsNullOrEmpty(Idioma3)))
                {
                    cmd.CommandText = "Insert into Idiomas (idAplicante,Idioma,Nivel) Values ( " + idUsuario + " , '" + Idioma3 + "' ,  '" + Nivel3 + "' )";
                    cmd.ExecuteNonQuery();

                    if (!(string.IsNullOrEmpty(Idioma4)))
                    {
                        cmd.CommandText = "Insert into Idiomas (idAplicante,Idioma,Nivel) Values ( " + idUsuario + " , '" + Idioma4 + "' ,  '" + Nivel4 + "' )";
                        cmd.ExecuteNonQuery();

                        if (!(string.IsNullOrEmpty(Idioma5)))
                        {
                            cmd.CommandText = "Insert into Idiomas (idAplicante,Idioma,Nivel) Values ( " + idUsuario + " , '" + Idioma5 + "' ,  '" + Nivel5 + "' )";
                            cmd.ExecuteNonQuery();
                            if (!(string.IsNullOrEmpty(Idioma6)))
                            {
                                cmd.CommandText = "Insert into Idiomas (idAplicante,Idioma,Nivel) Values ( " + idUsuario + " , '" + Idioma6 + "' ,  '" + Nivel6 + "' )";
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

            }

            conexion.Close();
            Response.Redirect("Certificaciones");
        }


    }
}
