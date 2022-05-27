using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;

namespace Login.Pages
{
    public class informacion_personalModel : PageModel
    {
        public int idUsuario { get; set; }
        [BindProperty]
        public int DiaNacimiento { get; set; }
        [BindProperty]
        public string MesNacimiento { get; set; }
        [BindProperty]
        public int AñoNacimiento { get; set; }
        [BindProperty]
        public string Nacionalidad { get; set; }
        [BindProperty]
        public string Genero { get; set; }
        [BindProperty]
        public string Civil { get; set; }
        [BindProperty]
        public string Perfil { get; set; }


        public void OnPost()
        {

            //string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos2;Uid=root;password=Gato1415*;";
            //MySqlConnection conexion = new MySqlConnection(connectionString);
            //conexion.Open();
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = conexion;
            //cmd.CommandText = "Insert into InfoPersonal (idAplicante,DiaNacimiento,MesNacimiento,AnioNacimiento,idNacionalidad,idGenero,idCivil) Values (" + idUsuario + ", '" + DiaNacimiento + ", '" + MesNacimiento + ", '" + AñoNacimiento + "' , (SELECT IdNacionalidad FROM Nacionalidad WHERE Nacionalidad = '" + Nacionalidad + "' )," + "' , (SELECT IdGenero FROM Genero WHERE Genero = '" + Genero + "' )," + "' , (SELECT IdCivil FROM EstadoCivil WHERE EstadoCivil = '" + Civil + "' )," + Perfil + "')";

            //cmd.ExecuteNonQuery();
            //conexion.Close();

            Console.WriteLine("Hola que tal");
            Console.WriteLine("IdUsuario ->" + idUsuario);
            Console.WriteLine("DiaNacimiento ->" + DiaNacimiento);
            Console.WriteLine("MesNacimiento ->" + MesNacimiento);
            Console.WriteLine("AñoNacimiento ->" + AñoNacimiento);
            Console.WriteLine("Nacionalidad ->" + Nacionalidad);
            Console.WriteLine("Genero ->" + Genero);
            Console.WriteLine("Civil ->" + Civil);
            Console.WriteLine("Perfil ->" + Perfil);

            Console.WriteLine("numeros");
            Console.WriteLine(DiaNacimiento);
            Console.WriteLine(MesNacimiento);
            Console.WriteLine(AñoNacimiento);



        }
    }
}
