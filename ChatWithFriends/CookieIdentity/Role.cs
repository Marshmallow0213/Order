using System.Collections.Generic;

namespace ChatWithFriends.Models
{
    public class Role
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}