using System;

namespace ChatWithFriends.ViewModels
{
    public class ShopCarViewModels
    {
        public int CupCount { get; set; }
        public string[] Name {  get; set; }
        public string[] TeaMaterials { get; set; }
        public string Ice { get; set; }
        public string Sugar { get; set; }

        public DateTime OrderTime { get; set; }
        public string OrderName { get; internal set; }
    }
}
