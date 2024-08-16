using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using ChatWithFriends.Models;
using System;
using CoreMvc5_CookieAuthentication.Services;
using ChatWithFriends.Interfaces;
using ChatWithFriends.ViewModels;

namespace ChatWithFriends.Data
{
    public class SafeContext : DbContext
    {
        private readonly IHashService _hashService;
        public SafeContext(DbContextOptions<SafeContext> options, IHashService hashService) : base(options)
        {
            _hashService = hashService;
        }

        public DbSet<Safe> Safes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Safe>().HasData(
                new Safe { OrderName = "弟弟",Shop = "波仕-鮮奶茶系列", Name = "沉香烏龍那提", CupCount = 1, Money2 = "65", Total = "75", TeaMaterialName="椰果", IceName="去冰", SugarName = "半糖", OrderTime = new DateTime(2024, 1, 1, 12, 30, 00) },
                new Safe { OrderName = "弟弟", Shop = "波仕-鮮奶茶系列", Name = "沉香烏龍那提", CupCount = 1, Money2 = "65", Total = "75", TeaMaterialName = "椰果", IceName = "去冰", SugarName = "半糖", OrderTime = new DateTime(2024, 2, 13, 13, 28, 29) },
                new Safe { OrderName = "弟弟", Shop = "波仕-鮮奶茶系列", Name = "沉香烏龍那提", CupCount = 1, Money2 = "65", Total = "75", TeaMaterialName = "椰果", IceName = "去冰", SugarName = "半糖", OrderTime = new DateTime(2024, 2, 13, 13, 30, 31) },
                new Safe { OrderName = "弟弟", Shop = "波仕-鮮奶茶系列", Name = "沉香烏龍那提", CupCount = 1, Money2 = "65", Total = "75", TeaMaterialName = "椰果", IceName = "去冰", SugarName = "半糖", OrderTime = new DateTime(2024, 5, 9, 4, 2, 17) }
            );
        }
    }
}
