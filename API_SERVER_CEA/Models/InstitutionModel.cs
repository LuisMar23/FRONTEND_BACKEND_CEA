using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace API_SERVER_CEA.Models
{
    public class Institution
    {
        [Key]
        public int Id { get; set; }
<<<<<<< HEAD
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public byte Estado { get; set; }
        public IEnumerable<InstitutionPerson> InstitucionPersona { get; set; }

=======

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public byte Estado { get; set; }
        public IEnumerable<InstitutionPerson> InstitucionPersona { get; set; }

>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669
    }
}
