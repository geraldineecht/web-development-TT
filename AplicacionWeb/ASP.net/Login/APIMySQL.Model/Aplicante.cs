using System;
namespace APIMySQL.Model
{
    public class Aplicante
    {
        public int idAplicante { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Correo { get; set; }
    }
}
