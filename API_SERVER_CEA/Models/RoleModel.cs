using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Role
    {
        [Key]
        public int idRol { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? nombreRol{ get; set; }

        public byte estadoRol { get; set; }

    }
}
