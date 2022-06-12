using System;
namespace APIMySQL.Model
{
    public class Entrevista
    {
        public int idEntrevista { get; set; }
        public int idUser { get; set; }
        public string fecha { get; set; }
        public int score { get; set; }
    }
}
