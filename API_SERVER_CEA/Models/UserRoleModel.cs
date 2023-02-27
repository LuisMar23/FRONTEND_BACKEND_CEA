using System.ComponentModel.DataAnnotations;

namespace API_SERVER_CEA.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
<<<<<<< HEAD
        public int UserId { get; set; }
        public User? User { get; set; }

        public int RoleId { get; set; }
        public Role? Role { get; set; }
=======
        public int userid { get; set; }
        public User? user { get; set; }

        public int roleid { get; set; }
        public Role? role { get; set; }
>>>>>>> 212794b20c6ab599e92a8a52ef6bc04bfa21b669

    }
}
