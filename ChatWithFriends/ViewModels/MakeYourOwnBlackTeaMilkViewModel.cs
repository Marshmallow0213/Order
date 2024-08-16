using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class MakeYourOwnBlackTeaMilkViewModel
    {
        public List<MakeYourOwnBlackTeaMilkFreshMilkTea> MakeYourOwnBlackTeaMilkFreshMilkTea { get; set; }
        public List<MakeYourOwnBlackTeaMilkbreasts> MakeYourOwnBlackTeaMilkbreasts { get; set; }
        public List<MakeYourOwnBlackTeaMilkFreshSheep> MakeYourOwnBlackTeaMilkFreshSheep { get; set; }
        public List<MakeYourOwnBlackTeaMilkGoodTea> MakeYourOwnBlackTeaMilkGoodTea { get; set; }
        public List<MakeYourOwnBlackTeaMilkCheeseMilkCap> MakeYourOwnBlackTeaMilkCheeseMilkCap { get; set; }
        public List<MakeYourOwnBlackTeaMilkFreshlySqueezed> MakeYourOwnBlackTeaMilkFreshlySqueezed { get; set; }
        public List<MakeYourOwnBlackTeaMilkSoyMilk> MakeYourOwnBlackTeaMilkSoyMilk { get; set; }
        public List<MakeYourOwnBlackTeaMilkMat> MakeYourOwnBlackTeaMilkMat { get; set; }
        public List<MakeYourOwnBlackTeaMilkIce> MakeYourOwnBlackTeaMilkIce { get; set; }
        public List<MakeYourOwnBlackTeaMilkSug> MakeYourOwnBlackTeaMilkSug { get; set; }
    }
    public class MakeYourOwnBlackTeaMilkFreshMilkTea
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
    public class MakeYourOwnBlackTeaMilkbreasts
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
    public class MakeYourOwnBlackTeaMilkFreshSheep
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
    public class MakeYourOwnBlackTeaMilkGoodTea
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
    public class MakeYourOwnBlackTeaMilkCheeseMilkCap
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
    public class MakeYourOwnBlackTeaMilkFreshlySqueezed
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
    public class MakeYourOwnBlackTeaMilkSoyMilk
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
    public class MakeYourOwnBlackTeaMilkMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class MakeYourOwnBlackTeaMilkIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class MakeYourOwnBlackTeaMilkSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
