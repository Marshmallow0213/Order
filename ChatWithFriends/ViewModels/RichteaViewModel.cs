using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ChatWithFriends.ViewModels
{
    public class RichteaViewModel
    {
        public List<RicThickMilkTea> RicThickMilkTea { get; set; }
        public List<RicSmallFarmerThickBreasts> RicSmallFarmerThickBreasts { get; set; }
        public List<RicPureThickTea> RicPureThickTea { get; set; }
        public List<RicFragrantMilkTea> RicFragrantMilkTea { get; set; }
        public List<RicRefreshingFruitTea> RicRefreshingFruitTea { get; set; }
        public List<RicChewySeries> RicChewySeries { get; set; }
        public List<RicRoyalGradeSpecialBlend> RicRoyalGradeSpecialBlend { get; set; }
        public List<RicMilkCapSpecialBlend> RicMilkCapSpecialBlend { get; set; }
        public List<RichteaMat> RichteaMat { get; set; }
        public List<RichteaIce> RichteaIce { get; set; }
        public List<RichteaSug> RichteaSug { get; set; }
    }
    public class RicThickMilkTea
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
    public class RicSmallFarmerThickBreasts
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
    public class RicPureThickTea
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
    public class RicFragrantMilkTea
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
    public class RicRefreshingFruitTea
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("大杯")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class RicChewySeries
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("大杯")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class RicRoyalGradeSpecialBlend
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("大杯")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class RicMilkCapSpecialBlend
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
    public class RichteaMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class RichteaIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class RichteaSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
