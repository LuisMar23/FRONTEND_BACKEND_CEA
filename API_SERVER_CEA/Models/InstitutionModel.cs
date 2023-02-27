using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class Institution
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public byte Estado { get; set; }
        public IEnumerable<InstitutionPerson> InstitucionPersona { get; set; }

    }
}
