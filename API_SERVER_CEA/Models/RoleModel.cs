using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public byte Estado { get; set; }


        public IEnumerable<UserRole> UsuariosRoles { get; set; }

    }
}
