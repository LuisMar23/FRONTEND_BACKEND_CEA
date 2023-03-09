using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Visit
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string actividad { get; set; }
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string lugar { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string observaciones { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string tipo { get; set; }

        public byte estado { get; set; }

        public int InstitutionId { get; set; }
        public Institution? Rol { get; set; }

        public int PersonaId { get; set; }
        public Person? Persona { get; set; }

    }
}
