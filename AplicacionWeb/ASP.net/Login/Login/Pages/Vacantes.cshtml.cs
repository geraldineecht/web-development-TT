using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace Atos.Pages
{
    public class VacantesModel : PageModel
    {
        public string NombreUsuario { get; set; }
        public int idUsuario { get; set; }
        public void OnGet()
        {
            NombreUsuario = HttpContext.Session.GetString("username");
            idUsuario = (int)HttpContext.Session.GetInt32("idAplicante");
        }
    }
}
