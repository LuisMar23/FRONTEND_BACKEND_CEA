using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.CodeDom.Compiler;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationContext contexto;

        private readonly IConfiguration _config;

        public LoginController(ApplicationContext _contexto,IConfiguration config)
        {
            contexto = _contexto;
            _config = config;
        }

        [HttpPost]
        public IActionResult Login(LoginUser userLogin)
        {
            var user = Authenticate(userLogin);
            if(user!=null)
            {
                var token = Generar(user);
                return Ok(token);
            }
            return NotFound("Usuario no encontrado");
           
        }
        [HttpGet]
        public IActionResult Get()
        {
            var currentUser = GetCurrentUser();
            return Ok($"{currentUser.Nombre}");
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
        private string Generar(User user)
        {
            var security = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credencial = new SigningCredentials(security, SecurityAlgorithms.HmacSha256);

            //Crear los claims

            //https://www.youtube.com/watch?v=tm8_merp_v0&t=10s
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Nombre),

            };
            //Crear el token
            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credencial);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new User
                {
                    Nombre = userClaims.FirstOrDefault(o => o.Type == ClaimTypes.NameIdentifier)?.Value
                };
            }
            return null;
        }
       
    }
}
