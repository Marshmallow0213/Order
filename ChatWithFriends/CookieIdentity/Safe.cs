using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace ChatWithFriends.Models
{
    public class Safe
    {
        [DisplayName("訂的人")]
        public string OrderName {  get; set; }  
        [DisplayName("飲料名稱")]
        public string Name { get; set; }
        [DisplayName("杯數")]
        [Required(ErrorMessage = "請輸入杯數")]
        public int CupCount { get; set; }
        [DisplayName("價格")]
        public string Money {  get; set; }
        [DisplayName("小杯價格")]
        public string Money1 { get; set; }
        [DisplayName("大杯價格")]
        public string Money2 { get; set; }

        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }

        [DisplayName("冰塊")]
        public string IceName { get; set; }

        [DisplayName("甜度")]
        public string SugarName { get; set; }
        [DisplayName("店家")]
        public string Shop {  get; set; }
        [Key]
        [DisplayName("點餐時間")]
        public DateTime OrderTime { get; set; }
        public string Total { get; internal set; }
    }
}
