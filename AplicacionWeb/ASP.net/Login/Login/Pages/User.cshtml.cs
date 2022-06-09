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
using Microsoft.Extensions.Configuration;


namespace Login.Pages
{
    public class UserModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public UserModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnPost(Usuarios acc)
        {
            string connectionString = _configuration.GetConnectionString("myDb1");
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

                // Para iniciar sesion y guardar el nombre del usuario
                HttpContext.Session.SetString("username", acc.NombreUsuario);
                HttpContext.Session.SetString("lastnameP", acc.ApellidoPaterno);
                HttpContext.Session.SetString("lastnameM", acc.ApellidoMaterno);
                HttpContext.Session.SetString("Correo", acc.Correo);


                // Para obtener el idAplicante
                cmd.CommandText = " Select idAplicante from Aplicante where Nombre= '" + acc.NombreUsuario + "  'and ApellidoP= '" + acc.ApellidoPaterno + "'  and ApellidoM= '" + acc.ApellidoMaterno + "'  and Correo= '" + acc.Correo + "'";
                object intAplicante = cmd.ExecuteScalar();
                int idAplicante = Convert.ToInt32(intAplicante);
                HttpContext.Session.SetInt32("idAplicante", idAplicante);

                conexion.Close();
                Response.Redirect("Vacantes");
            }
        }
    }
}