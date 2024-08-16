using System.ComponentModel.DataAnnotations;

namespace ChatWithFriends.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="帳戶")]
        public string Accont { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }
    }
}
