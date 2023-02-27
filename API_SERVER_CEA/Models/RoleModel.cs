using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Role
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? nombre { get; set; }

        public byte estado { get; set; }


        public IEnumerable<UserRole> UsuariosRoles { get; set; }

    }
}
