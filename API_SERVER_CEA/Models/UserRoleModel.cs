using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int userid { get; set; }
        public User? user { get; set; }

        public int roleid { get; set; }
        public Role? role { get; set; }

    }
}
