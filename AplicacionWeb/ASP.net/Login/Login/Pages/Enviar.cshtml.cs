using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;


namespace Atos.Pages
{
    public class EnviarModel : PageModel
    {
        public string Email { get; set; }
        public void OnGet()
        {
            Email = HttpContext.Session.GetString("Correo");
        }
    }
}
