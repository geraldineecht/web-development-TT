using System;
namespace Atos.Model
{
    public class ExpProfesional
    {
        public string PuestoExperiencia { get; set; }
        public string EmpresaExperiencia { get; set; }
        public int MesExperiencia { get; set; }
        public int AnioExperiencia { get; set; }
        public int MesExperienciaFin { get; set; }
        public int AnioExperienciaFin { get; set; }
        public string Actividades { get; set; }

        public ExpProfesional()
        {

        }
    }
}
