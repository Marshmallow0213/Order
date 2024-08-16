using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class AsherViewModel
    {
        public List<AsherTea> AsherTea { get; set; }
        public List<AsherYakult> AsherYakult { get; set; }
        public List<AsherSummerSmoothies> AsherSummerSmoothies { get; set; }
        public List<AsherMilkCover> AsherMilkCover { get; set; }
        public List<AsherMilk> AsherMilk { get; set; }
        public List<AsherMatcha> AsherMatcha { get; set; }
        public List<AsherAncient> AsherAncient { get; set; }
        public List<AsherChew> AsherChew { get; set; }
        public List<AsherFresh> AsherFresh { get; set; }
        public List<AsherTaro> AsherTaro { get; set; }
        public List<AsherMat> AsherMat { get; set; }
        public List<AsherIce> AsherIce { get; set; }
        public List<AsherSug> AsherSug { get; set; }
    }
    public class AsherTea
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
    public class AsherYakult
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
    public class AsherSummerSmoothies
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
    public class AsherMilkCover
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
    public class AsherMilk
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
    public class AsherMatcha
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
    public class AsherAncient
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
    public class AsherChew
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
    public class AsherFresh
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
    public class AsherTaro
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
    public class AsherMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class AsherIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class AsherSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
