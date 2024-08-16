using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ChatWithFriends.Models
{
    public class User
    {
        public string Id { get; set; }

        [DisplayName("名字")]
        public string Name { get; set; }

        [DisplayName("密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}