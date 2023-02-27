using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string?  Nombre { get; set; }
        public string? Contrasenia { get; set; }

        //public IEnumerable<UserRole> UsuariosRoles { get; set; }
    }
}
