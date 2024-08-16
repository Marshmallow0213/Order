using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ChatWithFriends.ViewModels
{
    public class SafeDrinkViewModel
    {
        [DisplayName("飲料名稱")]
        public string Name { get; set; }

        [DisplayName("杯數")]
        [Required(ErrorMessage = "請輸入杯數")]
        public int CupCount { get; set; }

        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }

        [DisplayName("冰塊")]
        public string IceName { get; set; }

        [DisplayName("甜度")]
        public string SugarName { get; set; }
    }
}
