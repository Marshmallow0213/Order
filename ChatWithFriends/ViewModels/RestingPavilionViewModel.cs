using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class RestingPavilionViewModel
    {
        public List<RestingPavilionFruit> RestingPavilionFruit { get; set; }
        public List<RestingPavilionMilk> RestingPavilionMilk { get; set; }
        public List<RestingPavilionTaiwan> RestingPavilionTaiwan { get; set; }
        public List<RestingPavilionLatte> RestingPavilionLatte { get; set; }
        public List<RestingPavilionRemember> RestingPavilionRemember { get; set; }
        public List<RestingPavilionMilkCheese> RestingPavilionMilkCheese { get; set; }
        public List<RestingPavilionGlobal> RestingPavilionGlobal { get; set; }
        public List<RestingPavilionMat> RestingPavilionMat { get; set; }
        public List<RestingPavilionIce> RestingPavilionIce { get; set; }
        public List<RestingPavilionSug> RestingPavilionSug { get; set; }
    }
    public class RestingPavilionFruit
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
    public class RestingPavilionMilk
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
    public class RestingPavilionTaiwan
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
    public class RestingPavilionLatte
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
    public class RestingPavilionRemember
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
    public class RestingPavilionMilkCheese
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
    public class RestingPavilionGlobal
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
    public class RestingPavilionMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class RestingPavilionIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class RestingPavilionSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
