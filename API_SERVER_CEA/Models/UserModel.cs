using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string?  Nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? Contrasenia { get; set; }

        public IEnumerable<UserRole> UsuariosRoles { get; set; }
    }
}
