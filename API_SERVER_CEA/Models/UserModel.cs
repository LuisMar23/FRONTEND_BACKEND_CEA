﻿using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class User
    {
        [Key]
        public int idUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string?  nombreUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public string? contraseniaUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no debe estar vacio")]
        public int estadoUsuario { get; set; }

        public int idRol { get; set; }
        public Role? Rol { get; set; }

        public int idPersona { get; set; }
        public Person? Persona { get; set; }
    }
}
