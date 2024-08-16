using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChatWithFriends.ViewModels
{
    public class LaiViewModel
    {
        public List<LaiTeaBag> LaiTeaBag { get; set; }
        public List<LaiFacia> LaiFacia { get; set; }
        public List<LaiTea> LaiTea { get; set; }
        public List<LaiMilkTea> LaiMilkTea { get; set; }
        public List<LaiAncient> LaiAncient { get; set; }
        public List<LaiOolong> LaiOolong { get; set; }
        public List<LaiWinterMelon> LaiWinterMelon { get; set; }
        public List<LaiQueen> LaiQueen { get; set; }
        public List<LaiTune> LaiTune { get; set; }
        public List<LaiSesame> LaiSesame { get; set; }
        public List<LaiMat> LaiMat { get; set; }
        public List<LaiIce> LaiIce { get; set; }
        public List<LaiSug> LaiSug { get; set; }
    }
    public class LaiTeaBag
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("盒")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiFacia
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiTea
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiMilkTea
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiAncient
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiOolong
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiWinterMelon
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiQueen
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiTune
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("瓶")]
        public double Money2 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiSesame
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("杯")]
        public double Money1 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class LaiMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class LaiIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage ="必須選擇")]
        public string IceName { get; set; }
    }
    public class LaiSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
