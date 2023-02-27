using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Visit
    {
        [Key]
        public int id { get; set; }
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? lugar { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? observaciones { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? tipo { get; set; }

        public byte estado { get; set; }

        public IEnumerable<Person> Personas { get; set; }
    }
}
