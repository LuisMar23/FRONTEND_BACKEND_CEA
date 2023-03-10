using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitasController : ControllerBase
    {
        private readonly ApplicationContext contexto;

        public VisitasController(ApplicationContext context)
        {
            contexto = context;
        }
        // GET: api/Visitas
        [HttpGet]
        //public async Task<ActionResult<List<DataVisit>>> ObtenerUsuarios()
        //{
        //    var datos = from v in this.contexto.Visita
        //                join i in this.contexto.Institucion on v.InstitutionId equals i.Id
        //                join p in this.contexto.Persona on v.PersonaId equals p.Id
        //                select new DataVisit
        //                {
        //                    idVisita = v.id,
        //                    lugarVisita = v.lugar,
        //                    observacionesVisita = v.observaciones,
        //                    fechaVisita = v.fecha

        //                };
        //    return await datos.ToListAsync();
        //}
        //[HttpGet]
        public async Task<ActionResult<List<Visit>>> ObtenerVisitas()
        {
            return await contexto.Visita.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<List<Visit>>> AgregarInstitucion(Visit institution)
        {
            Visit inst = await contexto.Visita.FirstOrDefaultAsync(x => x.fecha == institution.fecha);
            if (inst != null)
            {
                return BadRequest("Este institucion ya existe");
            }
            else
            {
                contexto.Visita.Add(institution);
                await contexto.SaveChangesAsync();
                return Ok();

            }
        }
    }
}
