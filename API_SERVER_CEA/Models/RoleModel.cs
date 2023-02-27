using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Role
    {
        [Key]
<<<<<<< HEAD
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public byte Estado { get; set; }
=======
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? nombre { get; set; }

        public byte estado { get; set; }
>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669


        public IEnumerable<UserRole> UsuariosRoles { get; set; }

    }
}
