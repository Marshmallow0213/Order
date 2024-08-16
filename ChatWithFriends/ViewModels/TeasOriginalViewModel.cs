using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChatWithFriends.ViewModels
{
    public class TeasOriginalViewModel
    {
        public List<TeasOriginalTea> TeasOriginalTea { get; set; }
        public List<TeasOriginalChew> TeasOriginalChew { get; set; }
        public List<TeasOriginalMilkAroma> TeasOriginalMilkAroma { get; set; }
        public List<TeasOriginalFruit> TeasOriginalFruit { get; set; }
        public List<TeasOriginalSpecialBlend> TeasOriginalSpecialBlend { get; set; }
        public List<TeasOriginalJapan> TeasOriginalJapan { get; set; }
        public List<TeasOriginalMilk> TeasOriginalMilk { get; set; }
        public List<TeasOriginalHot> TeasOriginalHot { get; set; }
        public List<TeasOriginalMat> TeasOriginalMat { get; set; }
        public List<TeasOriginalIce> TeasOriginalIce { get; set; }
        public List<TeasOriginalSug> TeasOriginalSug { get; set; }
    }
    public class TeasOriginalTea
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalChew
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalMilkAroma
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalFruit
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalSpecialBlend
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalJapan
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalMilk
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalHot
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money { get; set; }
        [DisplayName("大杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class TeasOriginalMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class TeasOriginalIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage ="必須選擇")]
        public string IceName { get; set; }
    }
    public class TeasOriginalSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
