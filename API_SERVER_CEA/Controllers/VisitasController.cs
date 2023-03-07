using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitasController : ControllerBase
    {
        private readonly ApplicationContext contexto;

        public VisitasController(ApplicationContext context)
        {
            this.contexto = context;
        }
        // GET: api/Visitas
        [HttpGet]
        public async Task<ActionResult<List<DataVisit>>> ObtenerUsuarios()
        {
            var datos = from v in this.contexto.Visita
                        join i in this.contexto.Institucion on v.InstitutionId equals i.Id
                        join p in this.contexto.Persona on v.PersonaId equals p.Id
                        select new DataVisit
                        {
                            idvisita = v.id,
                            lugarVisita = v.lugar,
                            observacionesVisita = v.observaciones,
                            tipoVisita = v.tipo,
                            nombrePersona = p.nombrePersona,
                            apellidoPersona = p.apellidoPersona,
                            ciPersona = p.ciPersona,
                            celularPersona = p.ciPersona,
                            tipoInstitucion = i.Tipo,
                            estadoVisita = v.estado
                        };
            return await datos.ToListAsync();
        }
    }
}
