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
    public class CertificacionesModel : PageModel
    {
        
        public int idUsuario { get; set; }
        [BindProperty]
        public string Certi1 { get; set; }
        [BindProperty]
        public int Anio1 { get; set; }
        [BindProperty]
        public string Certi2 { get; set; }
        [BindProperty]
        public int Anio2 { get; set; }
        [BindProperty]
        public string Certi3 { get; set; }
        [BindProperty]
        public int Anio3 { get; set; }
        [BindProperty]
        public string Certi4 { get; set; }
        [BindProperty]
        public int Anio4 { get; set; }
        [BindProperty]
        public string Certi5 { get; set; }
        [BindProperty]
        public int Anio5 { get; set; }
        [BindProperty]
        public string Certi6 { get; set; }
        [BindProperty]
        public int Anio6 { get; set; }
        [BindProperty]
        public string Certi7 { get; set; }
        [BindProperty]
        public int Anio7 { get; set; }
        [BindProperty]
        public string Certi8 { get; set; }
        [BindProperty]
        public int Anio8 { get; set; }

        private readonly IConfiguration _configuration;

        public CertificacionesModel(IConfiguration configuration)
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

            if (Certi1 == "Certificación")
            {
                Response.Redirect("Enviar");
            }
            else
            {
                cmd.CommandText = "Insert into Certificacion(idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi1 + "' ," + Anio1 + ")";
                cmd.ExecuteNonQuery();
            }

            if (Certi2 != "Certificación")
            {
                cmd.CommandText = "Insert into Certificacion (idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi2 + "' ,  " + Anio2 + " )";
                cmd.ExecuteNonQuery();

                if (Certi3 != "Certificación")
                {
                    cmd.CommandText = "Insert into Certificacion(idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi3 + "' ,  " + Anio3 + " )";
                    cmd.ExecuteNonQuery();

                    if (Certi4 != "Certificación")
                    {
                        cmd.CommandText = "Insert into Certificacion(idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi4 + "' ,  " + Anio4 + " )";
                        cmd.ExecuteNonQuery();

                        if (Certi5 != "Certificación")
                        {
                            cmd.CommandText = "Insert into Certificacion (idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi5 + "' ,  " + Anio5 + " )";
                            cmd.ExecuteNonQuery();
                            if (Certi6 != "Certificación")
                            {
                                cmd.CommandText = "Insert into Certificacion (idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi6 + "' ,  " + Anio6 + " )";
                                cmd.ExecuteNonQuery();
                                if (Certi7 != "Certificación")
                                {
                                    cmd.CommandText = "Insert into Certificacion (idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi7 + "' ,  " + Anio7 + " )";
                                    cmd.ExecuteNonQuery();
                                    if (Certi8 != "Certificación")
                                    {
                                        cmd.CommandText = "Insert into Certificacion (idAplicante,Certificacion,anio) Values ( " + idUsuario + " , '" + Certi8 + "' ,  " + Anio8 + " )";
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                    }
                }

            }

            conexion.Close();
            Response.Redirect("Enviar");
        }

    }
}
