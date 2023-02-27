using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class User
    {
        [Key]
        public int idUsuario { get; set; }

<<<<<<< HEAD
        public int Estado { get; set; }

=======
        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string  nombreUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string contraseniaUsuario { get; set; }

        public int estadoUsuario { get; set; }
>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669
        public IEnumerable<UserRole> UsuariosRoles { get; set; }
    }
}
