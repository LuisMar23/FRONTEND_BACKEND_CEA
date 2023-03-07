namespace API_SERVER_CEA.Models
{
    public class DataVisit
    {

        public int idvisita { get; set; }
        public string lugarVisita { get; set; }
        public string observacionesVisita { get; set; }
        public string tipoVisita { get; set; }
        public string nombrePersona { get; set; }
        public string apellidoPersona { get; set; }
        public int ciPersona { get; set; }
        public int celularPersona { get; set; }
        public string tipoInstitucion { get; set; }
        public int estadoVisita { get; set; }

    }
}
