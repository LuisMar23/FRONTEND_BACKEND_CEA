using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_SERVER_CEA.Context;
using API_SERVER_CEA.Models;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto.Engines;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace API_SERVER_CEA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public UsersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsuario()
        {
            return await _context.Usuario.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Usuario.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.idUsuario)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {

            _context.Usuario.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.idUsuario }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Usuario.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Usuario.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        //public string Encriptar(string cadena)
        //{
        //    byte[]inputBytes=Encoding.UTF8.GetBytes(cadena);
        //    byte[] encripted;
        //    RijndaelManaged cripto= new RijndaelManaged();
        //    using (MemoryStream ms =new MemoryStream(inputBytes.Length))
        //    {
        //        using (CryptoStream objCryptoStream = new CryptoStream(ms, cripto.CreateEncryptor(Clave, llave), CryptoStreamMode.Write)
        //        {
        //            objCryptoStream.Write(inputBytes,0,inputBytes.Length),
        //            objCryptoStream.FlushFinalBlock(),
        //            objCryptoStream.Close(),
        //        }
        //        encripted=ms.ToArray();

        //    }
        //    return Convert.ToBase64String(encripted);
        //}

        private bool UserExists(int id)
        {
            return _context.Usuario.Any(e => e.idUsuario == id);
        }
    }
}
