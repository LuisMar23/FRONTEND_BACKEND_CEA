using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Visit
    {
        [Key]
<<<<<<< HEAD
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public string? Lugar { get; set; }
    public string? Observaciones { get; set; }
    public string? Tipo { get; set; }

    public Byte Estado { get; set; }

    public IEnumerable<Person> Personas { get; set; }
}
=======
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
>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669
}
