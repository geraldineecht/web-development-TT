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

namespace Atos.Pages
{
    public class Sobre_miModel : PageModel
    {
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
        public string Habilidad6 { get; set; }
        [BindProperty]
        public string Habilidad7 { get; set; }
        [BindProperty]
        public string Habilidad8 { get; set; }
        [BindProperty]
        public string Habilidad9 { get; set; }

        public string[] Skills = new string[5]{ "name1", "name2", "name3", "name4", "name5" };

        public void OnPost()
        {
            for(int i = 0; i < 9; i++)
            {
                Console.WriteLine(Skills[i]);
            }


        }


        //public void OnGet()
        //{
        //}
    }
}
