using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ChatWithFriends.Data
{
    public class ApplicationUser
    {
        public string Id { get; set; }

        [DisplayName("名字")]
        public string Name { get; set; }

        [DisplayName("密碼")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("暱稱")]
        public string Nickname { get; set; }

        [DisplayName("Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("電話號碼")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }

    }
}
