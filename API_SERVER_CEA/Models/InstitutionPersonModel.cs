using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class InstitutionPerson
    {
        public int InstitutionId { get; set; }
        public Institution Institucion { get; set; }


        public int PersonId { get; set; }
        public Person Persona { get; set; }
    }
}
