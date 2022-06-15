using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIMySQL.Data.Repositories;
using APIMySQL.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Atos.Controllers
{
    [Route("api/APIMySQLController")]
    public class APIMySQLController : ControllerBase
    {
        private readonly AplicanteInterface _aplicanteInterface;

        public APIMySQLController(AplicanteInterface aplicanteInterface)
        {
            _aplicanteInterface = aplicanteInterface;
        }

        [HttpGet]
        public async Task<IActionResult> GetAplicantes()
        {
            return Ok(await _aplicanteInterface.GetAplicantes());
        }

        [HttpGet("{correo}")]
        public async Task<IActionResult> GetAplicante(string correo)
        {
            return Ok(await _aplicanteInterface.GetAplicante(correo));
        }

        //[HttpPost]
        //public async Task<IActionResult> PostAplicante([FromBody] Aplicante aplicante)
        //{
        //    if(aplicante == null)
        //    {
        //        return BadRequest();
        //    }
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var created = await _aplicanteInterface.InsertAplicante(aplicante);

        //    return Created("created", created);
        //}
    }
}
