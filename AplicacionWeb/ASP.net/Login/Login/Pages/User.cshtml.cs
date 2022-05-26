using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Login.Model;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;

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
            MySqlDataReader dr;
            cmd.Connection = conexion;
            cmd.CommandText = " Select * from Aplicante where Nombre= '" + acc.NombreUsuario + "  'and ApellidoP= '" + acc.ApellidoPaterno + "'  and ApellidoM= '" + acc.ApellidoMaterno + "'  and Correo= '" + acc.Correo + "'";
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                // Si el aplicante ya se encuentra en la base de datos
                dr.Close();
                conexion.Close();
                ViewData["Error"] = "¡Este aplicante ya esta registrado!";

            }
            else
            {
                // Si el aplicante no se repite
                dr.Close();
                cmd.CommandText = " Insert into Aplicante(Nombre,ApellidoP,ApellidoM,Correo) Values ('" + acc.NombreUsuario + "  ','" + acc.ApellidoPaterno + "' , '" + acc.ApellidoMaterno + "' , '" + acc.Correo + "')";
                cmd.ExecuteNonQuery();

                // Se ejecuta query para almacenar el idAplicante
                cmd.CommandText = " Select idAplicante from Aplicante where Nombre= '" + acc.NombreUsuario + "' and ApellidoP= '" + acc.ApellidoPaterno + "'  and ApellidoM= '" + acc.ApellidoMaterno + "'  and Correo= '" + acc.Correo + "'";
                cmd.ExecuteNonQuery();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        acc.idUser = Convert.ToInt32(reader["idAplicante"]);
                    }
                }
                conexion.Close();

                // Para iniciar sesion y guardar el nombre del usuario
                HttpContext.Session.SetString("username", acc.NombreUsuario);

                // Para iniciar sesion y guardar el id del usuario
                HttpContext.Session.SetInt32("idUser", acc.idUser);
                Response.Redirect("informacion_personal");
            }
        }
        private readonly ILogger<UserModel> _logger;

        public UserModel(ILogger<UserModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(Usuarios acc)
        {
            //string name = HttpContext.Request.Query["NombreUsuario"];
            
            
        }
    }
}
