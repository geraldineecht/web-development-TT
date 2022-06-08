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
using Atos.Model;

namespace Atos.Pages
{
    public class CVModel : PageModel
    {
        int idAplicante = 9;

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
        [BindProperty]
        public int PorcHabilidad1 { get; set; }
        [BindProperty]
        public int PorcHabilidad2 { get; set; }
        [BindProperty]
        public int PorcHabilidad3 { get; set; }
        [BindProperty]
        public int PorcHabilidad4 { get; set; }
        [BindProperty]
        public int PorcHabilidad5 { get; set; }
        [BindProperty]
        public string PorcHabilidad1_ { get; set; }
        [BindProperty]
        public string PorcHabilidad2_ { get; set; }
        [BindProperty]
        public string PorcHabilidad3_ { get; set; }
        [BindProperty]
        public string PorcHabilidad4_ { get; set; }
        [BindProperty]
        public string PorcHabilidad5_ { get; set; }
        [BindProperty]
        public string PuestoExperiencia { get; set; }
        [BindProperty]
        public string EmpresaExperiencia { get; set; }
        [BindProperty]
        public string AnioExperienciaInicio { get; set; }
        [BindProperty]
        public string AnioExperienciaFin { get; set; }
        [BindProperty]
        public string Actividades { get; set; }
        [BindProperty]
        public string MesExperienciaInicio { get; set; }
        [BindProperty]
        public string MesExperienciaFin { get; set; }
        [BindProperty]
        public string Institucion { get; set; }
        [BindProperty]
        public string Carrera { get; set; }
        [BindProperty]
        public string PaisFormacion { get; set; }
        [BindProperty]
        public string EstadoFormacion { get; set; }
        [BindProperty]
        public string CiudadFormacion { get; set; }
        [BindProperty]
        public string MesInicioFormacion { get; set; }
        [BindProperty]
        public string AnioInicioFormacion { get; set; }
        [BindProperty]
        public string MesFinalFormacion { get; set; }
        [BindProperty]
        public string AnioFinalFormacion { get; set; }
        public IList<Certificaciones> ListaCertificaciones { get; set; }
        public IList<Idiomas> ListaIdiomas { get; set; }






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
            
            cmd.CommandText = "SELECT u.idAplicante, u.AcercaDeMi, u.Habilidad1, u.Habilidad2, u.Habilidad3, u.Habilidad4, u.Habilidad5, r.PorcHabilidad1, r.PorcHabilidad2, r.PorcHabilidad3, r.PorcHabilidad4, r.PorcHabilidad5 FROM sobremi u JOIN  habilidades r ON u.idAplicante = r.idAplicante where u.idAplicante = " + idAplicante;
            var reader4 = cmd.ExecuteReader();
            reader4.Read();

            AcercaDeMi = reader4["AcercaDeMi"].ToString();
            Habilidad1 = reader4["Habilidad1"].ToString();
            Habilidad2 = reader4["Habilidad2"].ToString();
            Habilidad3 = reader4["Habilidad3"].ToString();
            Habilidad4 = reader4["Habilidad4"].ToString();
            Habilidad5 = reader4["Habilidad5"].ToString();
            
            PorcHabilidad1 = reader4.GetInt32(reader4.GetOrdinal("PorcHabilidad1"));
            PorcHabilidad2 = reader4.GetInt32(reader4.GetOrdinal("PorcHabilidad2"));
            PorcHabilidad3 = reader4.GetInt32(reader4.GetOrdinal("PorcHabilidad3"));
            PorcHabilidad4 = reader4.GetInt32(reader4.GetOrdinal("PorcHabilidad4"));
            PorcHabilidad5 = reader4.GetInt32(reader4.GetOrdinal("PorcHabilidad5"));

            PorcHabilidad1_ = reader4["PorcHabilidad1"].ToString() + "%";
            PorcHabilidad2_ = reader4["PorcHabilidad2"].ToString() + "%";
            PorcHabilidad3_ = reader4["PorcHabilidad3"].ToString() + "%";
            PorcHabilidad4_ = reader4["PorcHabilidad4"].ToString() + "%";
            PorcHabilidad5_ = reader4["PorcHabilidad5"].ToString() + "%";


            reader4.Close();



            cmd.CommandText = "SELECT u.idAplicante, u.PuestoExperiencia, u.EmpresaExperiencia, u.AnioExperienciaInicio, u.AnioExperienciaFin, u.Actividades, r.MesEscrito as 'MesExperienciaInicio', z.MesEscrito as 'MesExperienciaFin' FROM experienciaprofesional u JOIN  meses r ON u.MesExperienciaInicio = r.idMes JOIN meses z ON u.MesExperienciaFin = z.idMes where u.idAplicante = " + idAplicante;
            var reader5 = cmd.ExecuteReader();
            reader5.Read();

            PuestoExperiencia = reader5["PuestoExperiencia"].ToString();
            EmpresaExperiencia = reader5["EmpresaExperiencia"].ToString();
            AnioExperienciaInicio = reader5["AnioExperienciaInicio"].ToString();
            AnioExperienciaFin = reader5["AnioExperienciaFin"].ToString();
            Actividades = reader5["Actividades"].ToString();
            MesExperienciaInicio = reader5["MesExperienciaInicio"].ToString();
            MesExperienciaFin = reader5["MesExperienciaFin"].ToString();

            reader5.Close();

            cmd.CommandText = "SELECT u.idAplicante, u.Institucion, u.Carrera, u.Pais, u.Estado, u.Ciudad, u.AnioInicioFormacion, u.AnioFinalFormacion, r.MesEscrito as 'MesInicioFormacion', z.MesEscrito as 'MesFinalFormacion' FROM formacionacademica u JOIN  meses r ON u.MesInicioFormacion = r.idMes JOIN meses z ON u.MesFinalFormacion = z.idMes where u.idAplicante = " + idAplicante;
            var reader6 = cmd.ExecuteReader();
            reader6.Read();

            Institucion = reader6["Institucion"].ToString();
            Carrera = reader6["Carrera"].ToString();
            PaisFormacion = reader6["Pais"].ToString();
            EstadoFormacion = reader6["Estado"].ToString();
            CiudadFormacion = reader6["Ciudad"].ToString();
            MesInicioFormacion = reader6["MesInicioFormacion"].ToString();
            MesFinalFormacion = reader6["MesFinalFormacion"].ToString();
            AnioFinalFormacion = reader6["AnioFinalFormacion"].ToString();
            AnioInicioFormacion = reader6["AnioInicioFormacion"].ToString();

            reader6.Close();

            cmd.CommandText = "SELECT Idioma, Nivel FROM idiomas where idAplicante = " + idAplicante;


            Idiomas idioma1 = new Idiomas();
            ListaIdiomas = new List<Idiomas>();

            using (var reader7 = cmd.ExecuteReader())
            {
                while (reader7.Read())
                {
                    idioma1 = new Idiomas();
                    idioma1.Idioma = reader7["Idioma"].ToString();
                    idioma1.Nivel = reader7["Nivel"].ToString();
                    ListaIdiomas.Add(idioma1);
                }
            }

            


            cmd.CommandText = "SELECT Certificacion, Anio FROM certificacion where idAplicante = " + idAplicante;
            

            Certificaciones cert1 = new Certificaciones();
            ListaCertificaciones = new List<Certificaciones>();

            using (var reader8 = cmd.ExecuteReader())
            {
                while (reader8.Read())
                {
                    cert1 = new Certificaciones();
                    cert1.Certi = reader8["Certificacion"].ToString();
                    cert1.Anio = reader8.GetInt32(reader8.GetOrdinal("anio"));
                    ListaCertificaciones.Add(cert1);
                }
            }

            conexion.Dispose();

        }


        public void OnPost() 
        {
            
        }
    }
}
