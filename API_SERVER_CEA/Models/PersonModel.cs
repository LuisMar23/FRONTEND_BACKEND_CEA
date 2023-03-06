using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Person
    {
        [Key]
        public int idPersona { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? nombrePersona { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? apellidoPersona { get; set; }
        public int edadPersona { get; set; }

        public int ciPersona { get; set; }

        public int celularPersona { get; set; }

        public byte estadoPersona { get; set; }
    }
}
