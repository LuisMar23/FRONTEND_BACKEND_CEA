using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.CodeDom.Compiler;
using System.Security.Claims;
using System.Text;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationContext contexto;

        //private readonly IConfiguration _config;
        //public LoginController(IConfiguration config)
        //{
        //    _config = config;
        //}
        public LoginController(ApplicationContext _contexto)
        {
            contexto = _contexto;
        }

        [HttpPost]
        public IActionResult Login(LoginUser userLogin)
        {
            var user = Authenticate(userLogin);
            if(user!=null)
            {
                //var lista = from  in this.contexto.A
                //        join persona in this.contexto.Persona on autor.PersonaId equals persona.Id
                //        join centrotrabajo in this.contexto.CentroTrabajo on autor.CentroTrabajoId equals centrotrabajo.Id
                //        select new Autor
                //        {
                //            Id = autor.Id,
                //            Correo = autor.Correo,
                //            CentroTrabajo = centrotrabajo,
                //            Estado = autor.Estado,
                //            TipoAutor = autor.TipoAutor,
                //            Persona = persona,
                //            AutorTemas = autor.AutorTemas,
                //        };
                //var token = Generar(user);
                return Ok("usuario logueado");
            }
            return NotFound("Usuario no encontrado");
           
        }
        private User Authenticate(LoginUser userlogin)
        {
            var currentUser = contexto.Usuario.FirstOrDefault(user => user.Nombre.ToLower() == userlogin.UserName.ToLower() && user.Contrasenia == userlogin.Password);

            if(currentUser!=null)
            {
                return currentUser;
            }
            return null;
        }
        //private string Generate(User user)
        //{
        //    var security = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
        //    var credencial=new SigningCredentials(security, SecurityAlgorithms.HmacSha256);

        //    //Crear  los claims

        //    ///https://www.youtube.com/watch?v=tm8_merp_v0&t=10s
        //    //var claims =new[]
        //    //{
        //    //    new Claim(ClaimTypes.NameIdentifier, user.Nombre),
        //    //    new Claim(ClaimTypes.Role,)
        //    //}
        //    //Crear el token
        //}
    }
}
