using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly ApplicationContext contexto;

        public PersonasController(ApplicationContext context)
        {
            this.contexto = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<Person>>> AgregarPersona(Person persona)
        {
            var p = await contexto.Persona.FirstOrDefaultAsync(x => x.ciPersona == persona.ciPersona);
            if (p != null)
            {
                return BadRequest("Este Persona ya existe");
            }
            else
            {
                contexto.Persona.Add(p);
                await contexto.SaveChangesAsync();
                return Ok("Persona agregada con exito");

            }
        }
    }
}
