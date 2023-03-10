using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitucionController : ControllerBase
    {
        private readonly ApplicationContext contexto;

        public InstitucionController(ApplicationContext context)
        {
            this.contexto = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<Institution>>> AgregarInstitucion(Institution institution)
        {
            Institution inst = await contexto.Institucion.FirstOrDefaultAsync(x => x.Nombre == institution.Nombre);
            if (inst != null)
            {
                return BadRequest("Este institucion ya existe");
            }
            else
            {
                contexto.Institucion.Add(institution);
                await contexto.SaveChangesAsync();
                return Ok();

            }
        }

        [HttpGet]
        public async Task<ActionResult<List<Institution>>> ObtenerInstituciones(){

            return await contexto.Institucion.ToListAsync(); 
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<List<Institution>>> EditarInstituciones(int id, Institution institution)
        {
            Institution ins=await contexto.Institucion.FirstOrDefaultAsync(x=>x.Id == id); 
            if (ins == null)
            {
                return BadRequest("No se encontro la Institucion");
            }
            else
            {
                ins.Nombre = institution.Nombre;
                ins.Tipo = institution.Tipo;
                ins.Estado = institution.Estado;
                await contexto.SaveChangesAsync();
                return Ok();
            }
        }

    }
}
