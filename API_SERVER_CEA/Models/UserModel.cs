using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class User
    {
        [Key]
        public int idUsuario { get; set; }


        public int Estado { get; set; }


        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string  nombreUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string contraseniaUsuario { get; set; }

        public int estadoUsuario { get; set; }

        public IEnumerable<UserRole> UsuariosRoles { get; set; }
    }
}
