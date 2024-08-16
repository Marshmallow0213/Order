using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class WulinTeaViewModel
    {
        public List<WulinSoul> WulinSoul { get; set; }
        public List<WulinSpecialBlend> WulinSpecialBlend { get; set; }
        public List<WulinFifty> WulinFifty { get; set; }
        public List<WulinMaterial> WulinMaterial { get; set; }
        public List<WulinFruit> WulinFruit { get; set; }
        public List<WulinMilkTea> WulinMilkTea { get; set; }
        public List<WulinPurple> WulinPurple { get; set; }
        public List<WulinMat> WulinMat { get; set; }
        public List<WulinIce> WulinIce { get; set; }
        public List<WulinSug> WulinSug { get; set; }
    }
    public class WulinSoul
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WulinSpecialBlend
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WulinFifty
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WulinMaterial
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WulinFruit
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WulinMilkTea
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class WulinPurple
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
    public class WulinMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class WulinIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class WulinSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
