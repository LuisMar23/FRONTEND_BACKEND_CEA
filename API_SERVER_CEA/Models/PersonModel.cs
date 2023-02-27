using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Person
    {
        [Key]
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
}
