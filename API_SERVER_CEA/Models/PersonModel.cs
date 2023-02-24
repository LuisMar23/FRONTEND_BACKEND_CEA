using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }
        public int Edad { get;set; }

        public int  Ci { get; set; }

        public int Celular { get; set; }

        public Byte Estado { get; set; }

        public int VisitId { get; set; }
        public Visit Visit { get; set; }
        public IEnumerable<InstitutionPerson> InstitucionPersona { get; set; }
    }
}
