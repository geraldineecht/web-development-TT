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
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");

            string connectionString = "Server=127.0.0.1;Port=3306;Database=Atos2;Uid=root;password=Gato1415*;";
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = "Insert into InfoPersonal (idAplicante,DiaNacimiento,MesNacimiento,AnioNacimiento,idNacionalidad,idGenero,idCivil, idPerfil) Values (" + idUsuario + ", " + DiaNacimiento + ", " + MesNacimiento + ", " + AñoNacimiento + " , (SELECT IdNacionalidad FROM Nacionalidad WHERE Nacionalidad = '" + Nacionalidad + "' ), " + " (SELECT IdGenero FROM Genero WHERE Genero = '" + Genero + "' ), " + " (SELECT IdCivil FROM EstadoCivil WHERE EstadoCivil = '" + Civil + "' ), " + " (SELECT IdPerfil FROM Perfil WHERE TipoPerfil = '" + Perfil + "' ))";

            cmd.ExecuteNonQuery();
            conexion.Close();

            Response.Redirect("Informacion_de_contacto");

        }
    }
}
