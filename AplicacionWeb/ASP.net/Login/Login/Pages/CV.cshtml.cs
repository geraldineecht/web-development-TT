using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using Login.Model;

namespace Atos.Pages
{
    public class CVModel : PageModel
    {
        int idAplicante = 3;

        private readonly IConfiguration _configuration;
        public CVModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [BindProperty]
        public string NombreUsuario { get; set; }
        [BindProperty]
        public string ApellidoPaterno { get; set; }
        [BindProperty]
        public string ApellidoMaterno { get; set; }        
        [BindProperty]
        public string TipoPerfil { get; set; }
        [BindProperty]
        public string Nacionalidad { get; set; }
        [BindProperty]
        public string EstadoCivil { get; set; }
        [BindProperty]
        public string Genero { get; set; }
        [BindProperty]
        public string DiaNacimiento { get; set; }
        [BindProperty]
        public string MesNacimiento { get; set; }
        [BindProperty]
        public string AnioNacimiento { get; set; }
        [BindProperty]
        public string Telefono { get; set; }
        [BindProperty]
        public string CP { get; set; }
        [BindProperty]
        public string Direccion { get; set; }
        [BindProperty]
        public string NombreCiudad { get; set; }
        [BindProperty]
        public string NombreEstado { get; set; }
        [BindProperty]
        public string NombrePais { get; set; }
        [BindProperty]
        public string Correo { get; set; }
        [BindProperty]
        public string AcercaDeMi { get; set; }
        [BindProperty]
        public string Habilidad1 { get; set; }
        [BindProperty]
        public string Habilidad2 { get; set; }
        [BindProperty]
        public string Habilidad3 { get; set; }
        [BindProperty]
        public string Habilidad4 { get; set; }
        [BindProperty]
        public string Habilidad5 { get; set; }





        public void OnGet()
        {
            string connectionString = _configuration.GetConnectionString("myDb1");
            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexion;

            cmd.CommandText = "SELECT u.idAplicante, a.Nombre, a.ApellidoP, a.ApellidoM , r.TipoPerfil FROM infopersonal u  JOIN  perfil r ON u.idPerfil = r.idPerfil JOIN aplicante a ON a.idAplicante = u.idAplicante where a.idAplicante = "+ idAplicante + " group by idAplicante";
            var reader = cmd.ExecuteReader();
            reader.Read();
           
            NombreUsuario = reader["Nombre"].ToString();
            ApellidoPaterno = reader["ApellidoP"].ToString();
            ApellidoMaterno = reader["ApellidoM"].ToString();
            TipoPerfil = reader["TipoPerfil"].ToString();

            reader.Close();


            cmd.CommandText = "SELECT u.idAplicante, u.DiaNacimiento, u.MesNacimiento, u.AnioNacimiento, g.Genero, r.Nacionalidad, z.EstadoCivil FROM infopersonal u JOIN  nacionalidad r ON u.idNacionalidad = r.idNacionalidad JOIN genero g ON u.idGenero = g.idGenero JOIN estadocivil z ON u.idCivil = z.idCivil where u.idAplicante = " + idAplicante;
            var reader2 = cmd.ExecuteReader();
            reader2.Read();

            Genero = reader2["Genero"].ToString();
            Nacionalidad = reader2["Nacionalidad"].ToString();
            EstadoCivil = reader2["EstadoCivil"].ToString();
            DiaNacimiento = reader2["DiaNacimiento"].ToString();
            MesNacimiento = reader2["MesNacimiento"].ToString();
            AnioNacimiento = reader2["AnioNacimiento"].ToString();

            reader2.Close();

            cmd.CommandText = "SELECT u.idAplicante, u.Telefono, u.CP, u.Direccion, r.NombreCiudad, z.NombreEstado, p.NombrePais, a.Correo FROM infocontacto u JOIN  ciudad r ON u.idCiudad = r.idCiudad JOIN  estado z ON r.idEstado = z.idEstado JOIN pais p ON z.idPais = p.idPais JOIN aplicante a ON a.idAplicante = u.idAplicante where u.idAplicante = " + idAplicante;
            var reader3 = cmd.ExecuteReader();
            reader3.Read();

            Telefono = reader3["Telefono"].ToString();
            CP = reader3["CP"].ToString();
            Direccion = reader3["Direccion"].ToString();
            NombreCiudad = reader3["NombreCiudad"].ToString();
            NombreEstado = reader3["NombreEstado"].ToString();
            NombrePais = reader3["NombrePais"].ToString();
            Correo = reader3["Correo"].ToString();

            reader3.Close();
            
            cmd.CommandText = "SELECT * FROM sobremi where idAplicante = " + idAplicante;
            var reader4 = cmd.ExecuteReader();
            reader4.Read();

            AcercaDeMi = reader4["AcercaDeMi"].ToString();
            Habilidad1 = reader4["Habilidad1"].ToString();
            Habilidad2 = reader4["Habilidad2"].ToString();
            Habilidad3 = reader4["Habilidad3"].ToString();
            Habilidad4 = reader4["Habilidad4"].ToString();
            Habilidad5 = reader4["Habilidad5"].ToString();
            

            reader3.Close();



            conexion.Dispose();

            



        }


        public void OnPost() 
        {
            
        }
    }
}
