using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class UserRole
    {
        public int userid { get; set; }
        public User? user { get; set; }

        public int roleid { get; set; }
        public Role? role { get; set; }

    }
}
