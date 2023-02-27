using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Person
    {
        [Key]
<<<<<<< HEAD
    public int Id { get; set; }
    public string? Nombre { get; set; }

    public string? Apellido { get; set; }
    public int Edad { get; set; }

    public int Ci { get; set; }

    public int Celular { get; set; }

    public Byte Estado { get; set; }

    public int VisitId { get; set; }
    public Visit Visit { get; set; }
    public IEnumerable<InstitutionPerson> InstitucionPersona { get; set; }
}
=======
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? nombre { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? apellido { get; set; }
        public int edad { get; set; }

        public int ci { get; set; }

        public int celular { get; set; }

        public byte estado { get; set; }

        public int visitid { get; set; }
        public Visit Visit { get; set; }
        public IEnumerable<InstitutionPerson> InstitucionPerson { get; set; }
    }
>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669
}
