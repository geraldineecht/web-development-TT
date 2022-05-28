using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Atos.Model;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;


namespace Atos.Pages
{
    public class Informacion_de_contactoModel : PageModel
    {
        public int idUsuario { get; set; }
        [BindProperty]
        public string Telefono { get; set; }
        [BindProperty]
        public string Ciudad { get; set; }
        [BindProperty]
        public int CodigoPostal { get; set; }
        [BindProperty]
        public string Direccion { get; set; }



        //public string Telefono { get; set; }
        //public string Ciudad { get; set; }
        //public int CodigoPostal { get; set; }
        //public string Direccion { get; set; }




        public void OnPost()
        {
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
            Console.WriteLine("Mi ID ES: " + idUsuario);
            Console.WriteLine("Hola que tal");
            Console.WriteLine(Telefono);
            Console.WriteLine(Ciudad);
            Console.WriteLine(CodigoPostal);
            Console.WriteLine(Direccion);
            Console.WriteLine("Fallé");

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos2;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into InfoContacto (idAplicante,Telefono,idCiudad,CP,Direccion) Values (" + idUsuario + ", '" + Telefono + "' , (SELECT idCiudad FROM Ciudad WHERE NombreCiudad = '" + Ciudad + "' )," + CodigoPostal + ", '" + Direccion + "')";
            cmd.ExecuteNonQuery();
            conexion.Close();

            Console.WriteLine("Hola que tal");
            Console.WriteLine(idUsuario);



        }


    }
}