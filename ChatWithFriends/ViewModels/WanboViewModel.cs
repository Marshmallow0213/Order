using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class WanboViewModel
    {
        public List<WanboFeatured> WanboFeatured { get; set; }
        public List<WanboHandPath> WanboHandPath { get; set; }
        public List<WanboMilk> WanboMilk { get; set; }
        public List<WanboOld> WanboOld { get; set; }
        public List<WanboMilKTea> WanboMilKTea { get; set; }
        public List<WanboFruit> WanboFruit { get; set; }
        public List<WanboWinter> WanboWinter { get; set; }
        public List<WanboMat> WanboMat { get; set; }
        public List<WanboIce> WanboIce { get; set; }
        public List<WanboSug> WanboSug { get; set; }
    }
    public class WanboFeatured
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
    public class WanboHandPath
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
    public class WanboMilk
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
    public class WanboOld
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
    public class WanboMilKTea
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
    public class WanboFruit
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
    public class WanboWinter
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
    public class WanboMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class WanboIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class WanboSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
