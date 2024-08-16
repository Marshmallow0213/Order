using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChatWithFriends.ViewModels
{
    public class FiftyLanViewModel
    {
        public List<FiftyLanTea> FiftyLanTea { get; set; }
        public List<FiftyLanLatte> FiftyLanLatte { get; set; }
        public List<FiftyLanFresh> FiftyLanFresh { get; set; }
        public List<FiftyLanSeasonal> FiftyLanSeasonal { get; set; }
        public List<FiftyLanMat> FiftyLanMat { get; set; }
        public List<FiftyLanIce> FiftyLanIce { get; set; }
        public List<FiftyLanSug> FiftyLanSug { get; set; }
    }
    public class FiftyLanTea
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
    public class FiftyLanLatte
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
    public class FiftyLanFresh
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
    public class FiftyLanSeasonal
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
    public class FiftyLanMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class FiftyLanIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class FiftyLanSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
