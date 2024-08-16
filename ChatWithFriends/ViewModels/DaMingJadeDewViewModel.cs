using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ChatWithFriends.ViewModels
{
    public class DaMingJadeDewViewModel
    {
        public List<DaMingJadeDewClassic> DaMingJadeDewClassic { get; set; }
        public List<DaMingJadeDewOriginalTea> DaMingJadeDewOriginalTea { get; set; }
        public List<DaMingJadeDewLatte> DaMingJadeDewLatte { get; set; }
        public List<DaMingJadeDewMilkTea> DaMingJadeDewMilkTea { get; set; }
        public List<DaMingJadeDewNaigai> DaMingJadeDewNaigai { get; set; }
        public List<DaMingJadeDewWinterOnly> DaMingJadeDewWinterOnly { get; set; }
        public List<DaMingJadeDewFreshFruit> DaMingJadeDewFreshFruit { get; set; }
        public List<DaMingJadeDewMat> DaMingJadeDewMat { get; set; }
        public List<DaMingJadeDewIce> DaMingJadeDewIce { get; set; }
        public List<DaMingJadeDewSug> DaMingJadeDewSug { get; set; }
    }
    public class DaMingJadeDewClassic
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
    public class DaMingJadeDewOriginalTea
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
    public class DaMingJadeDewLatte
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
    public class DaMingJadeDewMilkTea
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
    public class DaMingJadeDewNaigai
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
    public class DaMingJadeDewWinterOnly
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("名字")]
        public string Name { get; set; }
        [DisplayName("小杯")]
        public double Money1 { get; set; }
        [DisplayName("冷熱")]
        public string temperature { get; set; }
    }
    public class DaMingJadeDewFreshFruit
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
    public class DaMingJadeDewMat
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("價格")]
        public double Money { get; set; }
        [DisplayName("加料")]
        public string TeaMaterialName { get; set; }
    }
    public class DaMingJadeDewIce
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("冰塊")]
        [Required(ErrorMessage = "必須選擇")]
        public string IceName { get; set; }
    }
    public class DaMingJadeDewSug
    {
        [Key, Column(Order = 0)]

        public string ID { get; set; }
        [DisplayName("甜度")]
        [Required(ErrorMessage = "必須選擇")]
        public string SugarName { get; set; }
    }
}
