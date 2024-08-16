using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;

namespace ChatWithFriends.ViewModels
{
    public class JinchaWuViewModel
    {
        public List<JinchaWuQKueh> JinchaWuQKueh { get; set; }
        public List<JinchaWuGoldenGoodTea> JinchaWuGoldenGoodTea { get; set; }
        public List<JinchaWuGoldenFresh> JinchaWuGoldenFresh { get; set; }
        public List<JinchaWuKimHougong> JinchaWuKimHougong { get; set; }
        public List<JinchaWuJinHaomian> JinchaWuJinHaomian { get; set; }
        public List<JinchaWuJinYoumi> JinchaWuJinYoumi { get; set; }
        public List<JinchaWuMat> JinchaWuMat { get; set; }
        public List<JinchaWuIce> JinchaWuIce { get; set; }
        public List<JinchaWuSug> JinchaWuSug { get; set; }
    }
    public class JinchaWuQKueh
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
    public class JinchaWuGoldenGoodTea
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
    public class JinchaWuGoldenFresh
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
    public class JinchaWuKimHougong
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
    public class JinchaWuJinHaomian
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
    public class JinchaWuJinYoumi
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
    public class JinchaWuMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class JinchaWuIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class JinchaWuSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
