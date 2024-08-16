using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class WongKeeTeaHouseViewModel
    {
        public List<WongKeeTeaHouseTea> WongKeeTeaHouseTea { get; set; }
        public List<WongKeeTeaHouseSpecialBlend> WongKeeTeaHouseSpecialBlend { get; set; }
        public List<WongKeeTeaHouseMat> WongKeeTeaHouseMat { get; set; }
        public List<WongKeeTeaHouseIce> WongKeeTeaHouseIce { get; set; }
        public List<WongKeeTeaHouseSug> WongKeeTeaHouseSug { get; set; }
    }
    public class WongKeeTeaHouseTea
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money1 { get; set; }
        [DisplayName("大杯")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WongKeeTeaHouseSpecialBlend
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money1 { get; set; }
        [DisplayName("大杯")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WongKeeTeaHouseMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class WongKeeTeaHouseIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class WongKeeTeaHouseSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
