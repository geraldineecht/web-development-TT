using System;
namespace Atos.Model
{
    public class InfoContacto
    {
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }
        public string Direccion { get; set; }

        public InfoContacto()
        {
        }
    }
}
