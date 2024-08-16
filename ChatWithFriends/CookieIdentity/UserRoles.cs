using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ChatWithFriends.Models
{
    public class UserRoles
    {
        [Key, Column(Order = 0)]
        public string UserId { get; set; }

        public User User { get; set; }

        [Key, Column(Order = 1)]
        public string RoleId { get; set; }
        public Role Role { get; set; } 
    }
}