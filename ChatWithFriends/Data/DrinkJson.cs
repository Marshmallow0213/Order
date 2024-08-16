using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using ChatWithFriends.Models;
using System;
using CoreMvc5_CookieAuthentication.Services;
using ChatWithFriends.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using ChatWithFriends.ViewModels;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.Arm;
using System.IO;
using System.Runtime.ConstrainedExecution;
namespace ChatWithFriends.Data
{
    public class DrinkJson
    {

        public class DrinkContext : DbContext
        {

            //ANiceholiday//
            public DbSet<ANiOriginalTea> ANiOriginalTea { get; set; }
            public DbSet<ANiflavoredTea> ANiflavoredTea { get; set; }
            public DbSet<ANiTasteTea> ANiTasteTea { get; set; }
            public DbSet<ANiMilkTea> ANiMilkTea { get; set; }
            public DbSet<ANiCheeseMilkCap> ANiCheeseMilkCap { get; set; }
            public DbSet<ANiFreshMilkTea> ANiFreshMilkTea { get; set; }
            public DbSet<ANiWinterMelonTea> ANiWinterMelonTea { get; set; }
            public DbSet<ANiceholidayMat> ANiceholidayMat { get; set; }
            public DbSet<ANiceholidayIce> ANiceholidayIce { get; set; }
            public DbSet<ANiceholidaySug> ANiceholidaySug { get; set; }
            //Richtea//
            public DbSet<RicThickMilkTea> RicThickMilkTea { get; set; }
            public DbSet<RicSmallFarmerThickBreasts> RicSmallFarmerThickBreasts { get; set; }
            public DbSet<RicPureThickTea> RicPureThickTea { get; set; }
            public DbSet<RicFragrantMilkTea> RicFragrantMilkTea { get; set; }
            public DbSet<RicRefreshingFruitTea> RicRefreshingFruitTea { get; set; }
            public DbSet<RicChewySeries> RicChewySeries { get; set; }
            public DbSet<RicRoyalGradeSpecialBlend> RicRoyalGradeSpecialBlend { get; set; }
            public DbSet<RicMilkCapSpecialBlend> RicMilkCapSpecialBlend { get; set; }
            public DbSet<RichteaMat> RichteaMat { get; set; }
            public DbSet<RichteaIce> RichteaIce { get; set; }
            public DbSet<RichteaSug> RichteaSug { get; set; }
            //BallsTea//
            public DbSet<BalTea> BalTea { get; set; }
            public DbSet<BalFreshmilktea> BalFreshmilktea { get; set; }
            public DbSet<BalHandpath> BalHandpath { get; set; }
            public DbSet<BalSnowfungus> BalSnowfungus { get; set; }
            public DbSet<BalMilktea> BalMilktea { get; set; }
            public DbSet<BalMilk> BalMilk { get; set; }
            public DbSet<BalCloudcover> BalCloudcover { get; set; }
            public DbSet<BalThickslices> BalThickslices { get; set; }
            public DbSet<BalFruity> BalFruity { get; set; }
            public DbSet<BalSpecialblend> BalSpecialblend { get; set; }
            public DbSet<BalWinterlimited> BalWinterlimited { get; set; }
            public DbSet<BallsTeaMat> BallsTeaMat { get; set; }
            public DbSet<BallsTeaIce> BallsTeaIce { get; set; }
            public DbSet<BallsTeaSug> BallsTeaSug { get; set; }
            //50嵐//
            public DbSet<FiftyLanTea> FiftyLanTea { get; set; }
            public DbSet<FiftyLanLatte> FiftyLanLatte { get; set; }
            public DbSet<FiftyLanFresh> FiftyLanFresh { get; set; }
            public DbSet<FiftyLanSeasonal> FiftyLanSeasonal { get; set; }
            public DbSet<FiftyLanMat> FiftyLanMat { get; set; }
            public DbSet<FiftyLanIce> FiftyLanIce { get; set; }
            public DbSet<FiftyLanSug> FiftyLanSug { get; set; }
            //LIKEFANG//
            public DbSet<LIKEFANGThickMilkCover> LIKEFANGThickMilkCover { get; set; }
            public DbSet<LIKEFANGFreshMilkTea> LIKEFANGFreshMilkTea { get; set; }
            public DbSet<LIKEFANGBrownSugar> LIKEFANGBrownSugar { get; set; }
            public DbSet<LIKEFANGFreshFruit> LIKEFANGFreshFruit { get; set; }
            public DbSet<LIKEFANGSpecialBlend> LIKEFANGSpecialBlend { get; set; }
            public DbSet<LIKEFANGKitKat> LIKEFANGKitKat { get; set; }
            public DbSet<LIKEFANGMilkTea> LIKEFANGMilkTea { get; set; }
            public DbSet<LIKEFANGTea> LIKEFANGTea { get; set; }
            public DbSet<LIKEFANGMat> LIKEFANGMat { get; set; }
            public DbSet<LIKEFANGIce> LIKEFANGIce { get; set; }
            public DbSet<LIKEFANGSug> LIKEFANGSug { get; set; }
            //COMEBUY//
            public DbSet<COMEBUYOriginalLeaves> COMEBUYOriginalLeaves { get; set; }
            public DbSet<COMEBUYFreshTeaLatte> COMEBUYFreshTeaLatte { get; set; }
            public DbSet<COMEBUYFreshFruitTea> COMEBUYFreshFruitTea { get; set; }
            public DbSet<COMEBUYReally> COMEBUYReally { get; set; }
            public DbSet<COMEBUYSummerOnly> COMEBUYSummerOnly { get; set; }
            public DbSet<COMEBUYMilkTeaCocoa> COMEBUYMilkTeaCocoa { get; set; }
            public DbSet<COMEBUYSpecialCoffee> COMEBUYSpecialCoffee { get; set; }
            public DbSet<COMEBUYWinterOnly> COMEBUYWinterOnly { get; set; }
            public DbSet<COMEBUYMat> COMEBUYMat { get; set; }
            public DbSet<COMEBUYIce> COMEBUYIce { get; set; }
            public DbSet<COMEBUYSug> COMEBUYSug { get; set; }

            //金茶伍//
            public DbSet<JinchaWuQKueh> JinchaWuQKueh { get; set; }
            public DbSet<JinchaWuGoldenGoodTea> JinchaWuGoldenGoodTea { get; set; }
            public DbSet<JinchaWuGoldenFresh> JinchaWuGoldenFresh { get; set; }
            public DbSet<JinchaWuKimHougong> JinchaWuKimHougong { get; set; }
            public DbSet<JinchaWuJinHaomian> JinchaWuJinHaomian { get; set; }
            public DbSet<JinchaWuJinYoumi> JinchaWuJinYoumi { get; set; }
            public DbSet<JinchaWuMat> JinchaWuMat { get; set; }
            public DbSet<JinchaWuIce> JinchaWuIce { get; set; }
            public DbSet<JinchaWuSug> JinchaWuSug { get; set; }
            //自己來紅茶鮮乳//
            public DbSet<MakeYourOwnBlackTeaMilkFreshMilkTea> MakeYourOwnBlackTeaMilkFreshMilkTea { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkbreasts> MakeYourOwnBlackTeaMilkbreasts { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkFreshSheep> MakeYourOwnBlackTeaMilkFreshSheep { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkGoodTea> MakeYourOwnBlackTeaMilkGoodTea { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkCheeseMilkCap> MakeYourOwnBlackTeaMilkCheeseMilkCap { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkFreshlySqueezed> MakeYourOwnBlackTeaMilkFreshlySqueezed { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkSoyMilk> MakeYourOwnBlackTeaMilkSoyMilk { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkMat> MakeYourOwnBlackTeaMilkMat { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkIce> MakeYourOwnBlackTeaMilkIce { get; set; }
            public DbSet<MakeYourOwnBlackTeaMilkSug> MakeYourOwnBlackTeaMilkSug { get; set; }
            //黃記茶莊//
            public DbSet<WongKeeTeaHouseTea> WongKeeTeaHouseTea { get; set; }
            public DbSet<WongKeeTeaHouseSpecialBlend> WongKeeTeaHouseSpecialBlend { get; set; }
            public DbSet<WongKeeTeaHouseMat> WongKeeTeaHouseMat { get; set; }
            public DbSet<WongKeeTeaHouseIce> WongKeeTeaHouseIce { get; set; }
            public DbSet<WongKeeTeaHouseSug> WongKeeTeaHouseSug { get; set; }
            //黛黛茶//
            public DbSet<DedeTeaRoyalchoiceitem> DedeTeaRoyalchoiceitem { get; set; }
            public DbSet<DedeTeaPrincessofFlowers> DedeTeaPrincessofFlowers { get; set; }
            public DbSet<DedeTeaRoyalLatte> DedeTeaRoyalLatte { get; set; }
            public DbSet<DedeTeaRoyalFragrantMilkTea> DedeTeaRoyalFragrantMilkTea { get; set; }
            public DbSet<DedeTeaClassicSpecialties> DedeTeaClassicSpecialties { get; set; }
            public DbSet<DedeTeaMat> DedeTeaMat { get; set; }
            public DbSet<DedeTeaIce> DedeTeaIce { get; set; }
            public DbSet<DedeTeaSug> DedeTeaSug { get; set; }
            //茶聚//
            public DbSet<CHAGESpecialBlend> CHAGESpecialBlend { get; set; }
            public DbSet<CHAGEMilk> CHAGEMilk { get; set; }
            public DbSet<CHAGETea> CHAGETea { get; set; }
            public DbSet<CHAGEScentedTea> CHAGEScentedTea { get; set; }
            public DbSet<CHAGEMilkTea> CHAGEMilkTea { get; set; }
            public DbSet<CHAGETeaGoodMat> CHAGETeaGoodMat { get; set; }
            public DbSet<CHAGESeasonal> CHAGESeasonal { get; set; }
            public DbSet<CHAGENaigai> CHAGENaigai { get; set; }
            public DbSet<CHAGEMat> CHAGEMat { get; set; }
            public DbSet<CHAGEIce> CHAGEIce { get; set; }
            public DbSet<CHAGESug> CHAGESug { get; set; }
            //大茗玉露青茶專賣店//
            public DbSet<DaMingJadeDewClassic> DaMingJadeDewClassic { get; set; }
            public DbSet<DaMingJadeDewOriginalTea> DaMingJadeDewOriginalTea { get; set; }
            public DbSet<DaMingJadeDewLatte> DaMingJadeDewLatte { get; set; }
            public DbSet<DaMingJadeDewMilkTea> DaMingJadeDewMilkTea { get; set; }
            public DbSet<DaMingJadeDewNaigai> DaMingJadeDewNaigai { get; set; }
            public DbSet<DaMingJadeDewWinterOnly> DaMingJadeDewWinterOnly { get; set; }
            public DbSet<DaMingJadeDewFreshFruit> DaMingJadeDewFreshFruit { get; set; }
            public DbSet<DaMingJadeDewMat> DaMingJadeDewMat { get; set; }
            public DbSet<DaMingJadeDewIce> DaMingJadeDewIce { get; set; }
            public DbSet<DaMingJadeDewSug> DaMingJadeDewSug { get; set; }
            //上宇林//
            public DbSet<ShangYulinTop> ShangYulinTop { get; set; }
            public DbSet<ShangYulinRich> ShangYulinRich { get; set; }
            public DbSet<ShangYulinMilk> ShangYulinMilk { get; set; }
            public DbSet<ShangYulinTea> ShangYulinTea { get; set; }
            public DbSet<ShangYulinHealth> ShangYulinHealth { get; set; }
            public DbSet<ShangYulinMountain> ShangYulinMountain { get; set; }
            public DbSet<ShangYulinMat> ShangYulinMat { get; set; }
            public DbSet<ShangYulinIce> ShangYulinIce { get; set; }
            public DbSet<ShangYulinSug> ShangYulinSug { get; set; }
            //萬波//
            public DbSet<WanboFeatured> WanboFeatured { get; set; }
            public DbSet<WanboHandPath> WanboHandPath { get; set; }
            public DbSet<WanboMilk> WanboMilk { get; set; }
            public DbSet<WanboOld> WanboOld { get; set; }
            public DbSet<WanboMilKTea> WanboMilKTea { get; set; }
            public DbSet<WanboFruit> WanboFruit { get; set; }
            public DbSet<WanboWinter> WanboWinter { get; set; }
            public DbSet<WanboMat> WanboMat { get; set; }
            public DbSet<WanboIce> WanboIce { get; set; }
            public DbSet<WanboSug> WanboSug { get; set; }
            //皇后先生//
            public DbSet<MrQueenTea> MrQueenTea { get; set; }
            public DbSet<MrQueenMilk> MrQueenMilk { get; set; }
            public DbSet<MrQueenCoffee> MrQueenCoffee { get; set; }
            public DbSet<MrQueenTallMilk> MrQueenTallMilk { get; set; }
            public DbSet<MrQueenFive> MrQueenFive { get; set; }
            public DbSet<MrQueenMat> MrQueenMat { get; set; }
            public DbSet<MrQueenIce> MrQueenIce { get; set; }
            public DbSet<MrQueenSug> MrQueenSug { get; set; }
            //歇腳亭//
            public DbSet<RestingPavilionFruit> RestingPavilionFruit { get; set; }
            public DbSet<RestingPavilionMilk> RestingPavilionMilk { get; set; }
            public DbSet<RestingPavilionTaiwan> RestingPavilionTaiwan { get; set; }
            public DbSet<RestingPavilionLatte> RestingPavilionLatte { get; set; }
            public DbSet<RestingPavilionRemember> RestingPavilionRemember { get; set; }
            public DbSet<RestingPavilionMilkCheese> RestingPavilionMilkCheese { get; set; }
            public DbSet<RestingPavilionGlobal> RestingPavilionGlobal { get; set; }
            public DbSet<RestingPavilionMat> RestingPavilionMat { get; set; }
            public DbSet<RestingPavilionIce> RestingPavilionIce { get; set; }
            public DbSet<RestingPavilionSug> RestingPavilionSug { get; set; }
            //日出茶太//
            public DbSet<SunriseTeaThickTeaLatte> SunriseTeaThickTeaLatte { get; set; }
            public DbSet<SunriseTeaTeaLatte> SunriseTeaTeaLatte { get; set; }
            public DbSet<SunriseTeaFresh> SunriseTeaFresh { get; set; }
            public DbSet<SunriseTeaMilk> SunriseTeaMilk { get; set; }
            public DbSet<SunriseTeaHealthy> SunriseTeaHealthy { get; set; }
            public DbSet<SunriseTeaCorridor> SunriseTeaCorridor { get; set; }
            public DbSet<SunriseTeaMat> SunriseTeaMat { get; set; }
            public DbSet<SunriseTeaIce> SunriseTeaIce { get; set; }
            public DbSet<SunriseTeaSug> SunriseTeaSug { get; set; }
            //老賴茶棧//
            public DbSet<LaiTeaBag> LaiTeaBag { get; set; }
            public DbSet<LaiFacia> LaiFacia { get; set; }
            public DbSet<LaiTea> LaiTea { get; set; }
            public DbSet<LaiMilkTea> LaiMilkTea { get; set; }
            public DbSet<LaiAncient> LaiAncient { get; set; }
            public DbSet<LaiOolong> LaiOolong { get; set; }
            public DbSet<LaiWinterMelon> LaiWinterMelon { get; set; }
            public DbSet<LaiQueen> LaiQueen { get; set; }
            public DbSet<LaiTune> LaiTune { get; set; }
            public DbSet<LaiSesame> LaiSesame { get; set; }
            public DbSet<LaiMat> LaiMat { get; set; }
            public DbSet<LaiIce> LaiIce { get; set; }
            public DbSet<LaiSug> LaiSug { get; set; }
            //武林茶//
            public DbSet<WulinSoul> WulinSoul { get; set; }
            public DbSet<WulinSpecialBlend> WulinSpecialBlend { get; set; }
            public DbSet<WulinFifty> WulinFifty { get; set; }
            public DbSet<WulinMaterial> WulinMaterial { get; set; }
            public DbSet<WulinFruit> WulinFruit { get; set; }
            public DbSet<WulinMilkTea> WulinMilkTea { get; set; }
            public DbSet<WulinPurple> WulinPurple { get; set; }
            public DbSet<WulinMat> WulinMat { get; set; }
            public DbSet<WulinIce> WulinIce { get; set; }
            public DbSet<WulinSug> WulinSug { get; set; }
            //Tea's原味//
            public DbSet<TeasOriginalTea> TeasOriginalTea { get; set; }
            public DbSet<TeasOriginalChew> TeasOriginalChew { get; set; }
            public DbSet<TeasOriginalMilkAroma> TeasOriginalMilkAroma { get; set; }
            public DbSet<TeasOriginalFruit> TeasOriginalFruit { get; set; }
            public DbSet<TeasOriginalSpecialBlend> TeasOriginalSpecialBlend { get; set; }
            public DbSet<TeasOriginalJapan> TeasOriginalJapan { get; set; }
            public DbSet<TeasOriginalMilk> TeasOriginalMilk { get; set; }
            public DbSet<TeasOriginalHot> TeasOriginalHot { get; set; }
            public DbSet<TeasOriginalMat> TeasOriginalMat { get; set; }
            public DbSet<TeasOriginalIce> TeasOriginalIce { get; set; }
            public DbSet<TeasOriginalSug> TeasOriginalSug { get; set; }
            //阿舍烏龍茶//
            public DbSet<AsherTea> AsherTea { get; set; }
            public DbSet<AsherYakult> AsherYakult { get; set; }
            public DbSet<AsherSummerSmoothies> AsherSummerSmoothies { get; set; }
            public DbSet<AsherMilkCover> AsherMilkCover { get; set; }
            public DbSet<AsherMilk> AsherMilk { get; set; }
            public DbSet<AsherMatcha> AsherMatcha { get; set; }
            public DbSet<AsherAncient> AsherAncient { get; set; }
            public DbSet<AsherChew> AsherChew { get; set; }
            public DbSet<AsherFresh> AsherFresh { get; set; }
            public DbSet<AsherTaro> AsherTaro { get; set; }
            public DbSet<AsherMat> AsherMat { get; set; }
            public DbSet<AsherIce> AsherIce { get; set; }
            public DbSet<AsherSug> AsherSug { get; set; }
            public DrinkContext(DbContextOptions<DrinkContext> options) : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //一沐日//
                modelBuilder.Entity<ANiOriginalTea> ().HasData(
                    new ANiOriginalTea { ID = "ANiOriginalTea001", Name = "竹香翡翠", Money = 40 },
                    new ANiOriginalTea { ID = "ANiOriginalTea002", Name = "招牌紅茶", Money = 35 },
                    new ANiOriginalTea { ID = "ANiOriginalTea003", Name = "炭培烏龍", Money = 35 },
                    new ANiOriginalTea { ID = "ANiOriginalTea004", Name = "油切蕎麥茶(推薦無糖)", Money = 35 },
                    new ANiOriginalTea { ID = "ANiOriginalTea005", Name = "手採高山青", Money = 35 }
                );
                modelBuilder.Entity <ANiflavoredTea> ().HasData(
                    new ANiflavoredTea { ID = "ANiflavoredTea001", Name = "梅果招牌紅", Money = 55},
                    new ANiflavoredTea { ID = "ANiflavoredTea002", Name = "荔枝蘆薈(甜度冰量固定)", Money = 60 },
                    new ANiflavoredTea { ID = "ANiflavoredTea003", Name = "鮮葡萄柚青茶", Money = 65 },
                    new ANiflavoredTea { ID = "ANiflavoredTea004", Name = "養樂多青茶", Money = 55 },
                    new ANiflavoredTea { ID = "ANiflavoredTea005", Name = "檸檬高山青", Money = 60 }
                );
                modelBuilder.Entity<ANiTasteTea> ().HasData(
                    new ANiTasteTea { ID = "ANiTasteTea001", Name = "粉粿桂花檸檬(甜度冰量固定)", Money = 60 },
                    new ANiTasteTea { ID = "ANiTasteTea002", Name = "粉粿黑糖檸檬(甜度冰量固定)", Money = 60 },
                    new ANiTasteTea { ID = "ANiTasteTea003", Name = "荔枝烏龍", Money = 55 },
                    new ANiTasteTea { ID = "ANiTasteTea004", Name = "桂花蕎麥茶(推薦半糖)", Money = 55 },
                    new ANiTasteTea { ID = "ANiTasteTea005", Name = "柚子烏龍(冷飲冰量固定)", Money = 65 }
                );
                modelBuilder.Entity <ANiMilkTea> ().HasData(
                    new ANiMilkTea { ID = "ANiMilkTea001", Name = "招牌紅奶茶", Money = 50 },
                    new ANiMilkTea { ID = "ANiMilkTea002", Name = "粉粿黑糖奶茶(甜度冰量固定)", Money = 60 },
                    new ANiMilkTea { ID = "ANiMilkTea003", Name = "黃金蕎麥奶茶", Money = 50 },
                    new ANiMilkTea { ID = "ANiMilkTea004", Name = "逮丸奶茶", Money = 65 },
                    new ANiMilkTea { ID = "ANiMilkTea005", Name = "極黑芝麻奶茶", Money = 65 },
                    new ANiMilkTea { ID = "ANiMilkTea006", Name = "竹香翡翠奶茶", Money = 50 }
                );
                modelBuilder.Entity<ANiCheeseMilkCap> ().HasData(
                    new ANiCheeseMilkCap { ID = "ANiCheeseMilkCap001", Name = "奶蓋招牌紅", Money = 65 },
                    new ANiCheeseMilkCap { ID = "ANiCheeseMilkCap002", Name = "奶蓋竹香茶", Money = 65 },
                    new ANiCheeseMilkCap { ID = "ANiCheeseMilkCap003", Name = "奶蓋烏龍茶", Money = 65 },
                    new ANiCheeseMilkCap { ID = "ANiCheeseMilkCap004", Name = "奶蓋蕎麥茶(推薦無糖)", Money = 65 }
                );
                modelBuilder.Entity <ANiFreshMilkTea> ().HasData(
                    new ANiFreshMilkTea { ID = "ANiFreshMilkTea001", Name = "招牌紅拿鐵", Money = 70 },
                    new ANiFreshMilkTea { ID = "ANiFreshMilkTea002", Name = "烏龍拿鐵", Money = 70 },
                    new ANiFreshMilkTea { ID = "ANiFreshMilkTea003", Name = "黃金蕎麥拿鐵", Money = 70 },
                    new ANiFreshMilkTea { ID = "ANiFreshMilkTea004", Name = "竹香翡翠拿鐵", Money = 70 },
                    new ANiFreshMilkTea { ID = "ANiFreshMilkTea005", Name = "極黑芝麻拿鐵", Money = 80 }
                );
                modelBuilder.Entity<ANiWinterMelonTea> ().HasData(
                    new ANiWinterMelonTea { ID = "ANiWinterMelonTea001", Name = "招牌冬瓜紅", Money = 45 },
                    new ANiWinterMelonTea { ID = "ANiWinterMelonTea002", Name = "冬瓜青茶", Money = 45 },
                    new ANiWinterMelonTea { ID = "ANiWinterMelonTea003", Name = "冬瓜檸檬", Money = 50 },
                    new ANiWinterMelonTea { ID = "ANiWinterMelonTea004", Name = "冬瓜仙草蜜(冰量固定)", Money = 50 }
                );
                modelBuilder.Entity<ANiceholidayMat>().HasData(
                    new ANiceholidayMat { ID = "ANiceholidayMat001", TeaMaterialName = "草仔粿", Money = 15 },
                    new ANiceholidayMat { ID = "ANiceholidayMat002", TeaMaterialName = "招牌粉粿", Money = 10 },
                    new ANiceholidayMat { ID = "ANiceholidayMat003", TeaMaterialName = "琥珀粉圓", Money = 10 },
                    new ANiceholidayMat { ID = "ANiceholidayMat004", TeaMaterialName = "蘆薈", Money = 10 },
                    new ANiceholidayMat { ID = "ANiceholidayMat005", TeaMaterialName = "雙粉（粉粿+粉圓）", Money = 10 },
                    new ANiceholidayMat { ID = "ANiceholidayMat006", TeaMaterialName = "嫩仙草", Money = 10 },
                    new ANiceholidayMat { ID = "ANiceholidayMat007", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<ANiceholidayIce>().HasData(
                    new ANiceholidayIce { ID = "ANiceholidayIce001", IceName = "正常冰" },
                    new ANiceholidayIce { ID = "ANiceholidayIce002", IceName = "少冰" },
                    new ANiceholidayIce { ID = "ANiceholidayIce003", IceName = "微冰" },
                    new ANiceholidayIce { ID = "ANiceholidayIce004", IceName = "去冰(小碎冰)" },
                    new ANiceholidayIce { ID = "ANiceholidayIce005", IceName = "完全去冰" }
                );
                modelBuilder.Entity<ANiceholidaySug>().HasData(
                    new ANiceholidaySug { ID = "ANiceholidaySug001", SugarName = "正常甜" },
                    new ANiceholidaySug { ID = "ANiceholidaySug002", SugarName = "七分甜" },
                    new ANiceholidaySug { ID = "ANiceholidaySug003", SugarName = "五分甜" },
                    new ANiceholidaySug { ID = "ANiceholidaySug004", SugarName = "三分甜" },
                    new ANiceholidaySug { ID = "ANiceholidaySug005", SugarName = "一分糖" },
                    new ANiceholidaySug { ID = "ANiceholidaySug006", SugarName = "無糖" }
                );


                //厚味茶理//
                modelBuilder.Entity<RicThickMilkTea>().HasData(
                    new RicThickMilkTea { ID = "RicThickMilkTea001", Name = "經典‧厚奶茶", Money1 = 50, Money2 = 60 },
                    new RicThickMilkTea { ID = "RicThickMilkTea002", Name = "金蕎麥‧厚奶茶", Money1 = 45, Money2 = 55 },
                    new RicThickMilkTea { ID = "RicThickMilkTea003", Name = "烏龍‧厚奶茶", Money1 = 55, Money2 = 65 },
                    new RicThickMilkTea { ID = "RicThickMilkTea004", Name = "蜜珍珠‧厚奶茶", Money1 = 55, Money2 = 65 },
                    new RicThickMilkTea { ID = "RicThickMilkTea005", Name = "日式抹茶‧厚奶茶", Money1 = 65, Money2 = 75 },
                    new RicThickMilkTea { ID = "RicThickMilkTea006", Name = "法式濃情‧厚奶茶", Money1 = 65, Money2 = 75 },
                    new RicThickMilkTea { ID = "RicThickMilkTea007", Name = "小芋園炭焙‧厚奶茶", Money1 = 75, Money2 = 85 }
                );
                modelBuilder.Entity<RicSmallFarmerThickBreasts>().HasData(
                    new RicSmallFarmerThickBreasts { ID = "RicSmallFarmerThickBreasts001", Name = "紅茶小農鮮奶", Money1 = 60, Money2 = 70 },
                    new RicSmallFarmerThickBreasts { ID = "RicSmallFarmerThickBreasts002", Name = "金蕎麥小農鮮奶", Money1 = 55, Money2 = 65 },
                    new RicSmallFarmerThickBreasts { ID = "RicSmallFarmerThickBreasts003", Name = "鐵觀音小農鮮奶", Money1 = 65, Money2 = 75 },
                    new RicSmallFarmerThickBreasts { ID = "RicSmallFarmerThickBreasts004", Name = "冬瓜珍珠鮮奶", Money1 = 70, Money2 = 80 },
                    new RicSmallFarmerThickBreasts { ID = "RicSmallFarmerThickBreasts005", Name = "小芋園布丁鮮奶", Money1 = 75, Money2 = 85 }
                );
                modelBuilder.Entity<RicPureThickTea>().HasData(
                    new RicPureThickTea { ID = "RicPureThickTea001", Name = "黃金蕎麥茶", Money1 = 25, Money2 = 30 },
                    new RicPureThickTea { ID = "RicPureThickTea002", Name = "厚韻紅茶", Money1 = 30, Money2 = 35 },
                    new RicPureThickTea { ID = "RicPureThickTea003", Name = "茉香綠茶", Money1 = 30, Money2 = 35 },
                    new RicPureThickTea { ID = "RicPureThickTea004", Name = "翠韻高山青", Money1 = 30, Money2 = 35 },
                    new RicPureThickTea { ID = "RicPureThickTea005", Name = "金鳳烏龍茶", Money1 = 35, Money2 = 40 },
                    new RicPureThickTea { ID = "RicPureThickTea006", Name = "炭焙鐵觀音", Money1 = 40, Money2 = 45 }
                );
                modelBuilder.Entity<RicFragrantMilkTea>().HasData(
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea001", Name = "英式奶茶", Money1 = 40, Money2 = 50 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea002", Name = "茉香奶綠", Money1 = 40, Money2 = 50 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea003", Name = "珍珠奶茶", Money1 = 45, Money2 = 55 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea004", Name = "炭焙觀音奶茶", Money1 = 50, Money2 = 60 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea005", Name = "茉香凍‧綠奶茶", Money1 = 50, Money2 = 60 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea006", Name = "手做布丁奶茶", Money1 = 50, Money2 = 60 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea007", Name = "醇厚烏龍可可", Money1 = 50, Money2 = 60 },
                    new RicFragrantMilkTea { ID = "RicFragrantMilkTea008", Name = "五力全開奶茶", Money2 = 65 }
                );
                modelBuilder.Entity<RicRefreshingFruitTea>().HasData(
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea001", Name = "翡翠檸檬", Money2 = 55},
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea002", Name = "檸檬百香紅", Money2 = 55 },
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea003", Name = "雪花梅子綠", Money2 = 55 },
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea004", Name = "金桔脆梅青", Money2 = 60 },
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea005", Name = "金桔鮮檸", Money2 = 50 },
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea006", Name = "鮮果百香綠", Money2 = 55 },
                    new RicRefreshingFruitTea { ID = "RicRefreshingFruitTea007", Name = "柳橙翡翠", Money2 = 60 }
                );
                modelBuilder.Entity<RicChewySeries>().HasData(
                    new RicChewySeries { ID = "RicChewySeries001", Name = "金桔百QQ", Money2 = 60 },
                    new RicChewySeries { ID = "RicChewySeries002", Name = "青清檸香3Q", Money2 = 60 },
                    new RicChewySeries { ID = "RicChewySeries003", Name = "府城冬瓜蜜珍珠", Money2 = 55 },
                    new RicChewySeries { ID = "RicChewySeries004", Name = "冰梅青翡翠凍", Money2 = 65 },
                    new RicChewySeries { ID = "RicChewySeries005", Name = "柳橙百香綠茶凍", Money2 = 65 }
                );
                modelBuilder.Entity<RicRoyalGradeSpecialBlend>().HasData(
                    new RicRoyalGradeSpecialBlend { ID = "RicRoyalGradeSpecialBlend001", Name = "檸夏冬瓜露", Money2 = 60 },
                    new RicRoyalGradeSpecialBlend { ID = "RicRoyalGradeSpecialBlend002", Name = "懷舊蕎麥冬瓜", Money2 = 60 },
                    new RicRoyalGradeSpecialBlend { ID = "RicRoyalGradeSpecialBlend003", Name = "蜂蜜烏龍奶茶", Money2 = 60 },
                    new RicRoyalGradeSpecialBlend { ID = "RicRoyalGradeSpecialBlend004", Name = "府城冬瓜冰茶", Money2 = 65 },
                    new RicRoyalGradeSpecialBlend { ID = "RicRoyalGradeSpecialBlend005", Name = "多多綠茶", Money2 = 90 }
                );
                modelBuilder.Entity<RicMilkCapSpecialBlend>().HasData(
                    new RicMilkCapSpecialBlend { ID = "RicMilkCapSpecialBlend001", Name = "雲朵奶蓋‧金蕎麥", Money1 = 50, Money2 = 60 },
                    new RicMilkCapSpecialBlend { ID = "RicMilkCapSpecialBlend002", Name = "雲朵奶蓋‧厚顏紅", Money1 = 55, Money2 = 65 },
                    new RicMilkCapSpecialBlend { ID = "RicMilkCapSpecialBlend003", Name = "雲朵奶蓋‧茉香綠", Money1 = 55, Money2 = 65 },
                    new RicMilkCapSpecialBlend { ID = "RicMilkCapSpecialBlend004", Name = "雲朵奶蓋‧濃醇可可", Money1 = 65, Money2 = 75 },
                    new RicMilkCapSpecialBlend { ID = "RicMilkCapSpecialBlend005", Name = "雲朵奶蓋‧日式綠茶", Money1 = 75, Money2 = 85 }
                );
                modelBuilder.Entity<RichteaMat>().HasData(
                    new RichteaMat { ID = "RichteaMat001", TeaMaterialName = "珍珠", Money = 5 },
                    new RichteaMat { ID = "RichteaMat002", TeaMaterialName = "椰果", Money = 10 },
                    new RichteaMat { ID = "RichteaMat003", TeaMaterialName = "雙色小芋園", Money = 15 },
                    new RichteaMat { ID = "RichteaMat004", TeaMaterialName = "手作布丁", Money = 10 },
                    new RichteaMat { ID = "RichteaMat005", TeaMaterialName = "綠茶凍", Money = 10 },
                    new RichteaMat { ID = "RichteaMat006", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<RichteaIce>().HasData(
                    new RichteaIce { ID = "RichteaIce001", IceName = "正常" },
                    new RichteaIce { ID = "RichteaIce002", IceName = "少冰" },
                    new RichteaIce { ID = "RichteaIce003", IceName = "微冰" },
                    new RichteaIce { ID = "RichteaIce004", IceName = "去冰" },
                    new RichteaIce { ID = "RichteaIce005", IceName = "溫" },
                    new RichteaIce { ID = "RichteaIce006", IceName = "熱" }
                );
                modelBuilder.Entity<RichteaSug>().HasData(
                    new RichteaSug { ID = "RichteaSug001", SugarName = "全糖" },
                    new RichteaSug { ID = "RichteaSug002", SugarName = "少糖" },
                    new RichteaSug { ID = "RichteaSug003", SugarName = "半糖" },
                    new RichteaSug { ID = "RichteaSug004", SugarName = "微糖" },
                    new RichteaSug { ID = "RichteaSug005", SugarName = "一分糖" },
                    new RichteaSug { ID = "RichteaSug006", SugarName = "無糖" }
                );
                //波仕//
                modelBuilder.Entity<BalTea>().HasData(
                    new BalTea { ID = "BalTea001", Name = "冬片烏龍", Money2 = 45 },
                    new BalTea { ID = "BalTea002", Name = "菩爾紅茶", Money2 = 40 },
                    new BalTea { ID = "BalTea003", Name = "烏龍綠茶", Money2 = 40 },
                    new BalTea { ID = "BalTea004", Name = "悠娜紅茶", Money2 = 35 },
                    new BalTea { ID = "BalTea005", Name = "波樣綠茶", Money2 = 35 },
                    new BalTea { ID = "BalTea006", Name = "高山青茶", Money2 = 35 },
                    new BalTea { ID = "BalTea007", Name = "沉香烏龍", Money2 = 35 },
                    new BalTea { ID = "BalTea008", Name = "焙香大麥茶", Money2 = 30 }
                );
                modelBuilder.Entity<BalFreshmilktea>().HasData(
                    new BalFreshmilktea { ID = "BalFreshmilktea001", Name = "悠娜紅茶那堤", Money1 = 55, Money2 = 65 },
                    new BalFreshmilktea { ID = "BalFreshmilktea002", Name = "沉香烏龍那提", Money1 = 55, Money2 = 65 },
                    new BalFreshmilktea { ID = "BalFreshmilktea003", Name = "波樣綠茶那提", Money1 = 55, Money2 = 65 },
                    new BalFreshmilktea { ID = "BalFreshmilktea004", Name = "焙香大麥那提", Money1 = 50, Money2 = 60 },
                    new BalFreshmilktea { ID = "BalFreshmilktea005", Name = "泰式鮮奶茶", Money1 = 60, Money2 = 70 },
                    new BalFreshmilktea { ID = "BalFreshmilktea006", Name = "冬瓜那堤", Money1 = 60, Money2 = 70 }
                );
                modelBuilder.Entity<BalHandpath>().HasData(
                    new BalHandpath { ID = "BalHandpath001", Name = "仙波粉", Money2 = 50 },
                    new BalHandpath { ID = "BalHandpath002", Name = "青青粉波椰", Money2 = 50 },
                    new BalHandpath { ID = "BalHandpath003", Name = "綠豆粉條", Money2 = 50 },
                    new BalHandpath { ID = "BalHandpath004", Name = "檸檬冬瓜粉條", Money2 = 55 },
                    new BalHandpath { ID = "BalHandpath005", Name = "鴉片檸檬", Money2 = 55 },
                    new BalHandpath { ID = "BalHandpath006", Name = "古早味仙草蜜", Money2 = 45 },
                    new BalHandpath { ID = "BalHandpath007", Name = "黑金仙甘茶", Money2 = 40 }
                );
                modelBuilder.Entity<BalSnowfungus>().HasData(
                    new BalSnowfungus { ID = "BalSnowfungus001", Name = "雪耳莎沙亞", Money1 = 75 },
                    new BalSnowfungus { ID = "BalSnowfungus002", Name = "黑糖鮮奶雪耳", Money1 = 75 },
                    new BalSnowfungus { ID = "BalSnowfungus003", Name = "桂花雪耳綠那堤", Money1 = 75 },
                    new BalSnowfungus { ID = "BalSnowfungus004", Name = "桂花檸檬雪耳", Money2 = 75 },
                    new BalSnowfungus { ID = "BalSnowfungus005", Name = "沁爽百香雪耳飲", Money2 = 75 }
                );
                modelBuilder.Entity<BalMilktea>().HasData(
                    new BalMilktea { ID = "BalMilktea001", Name = "粉條黑糖奶茶", Money1 = 55, Money2 = 65 },
                    new BalMilktea { ID = "BalMilktea002", Name = "3喜奶茶", Money1 = 55, Money2 = 65 },
                    new BalMilktea { ID = "BalMilktea003", Name = "珍珠奶茶", Money1 = 50, Money2 = 60 },
                    new BalMilktea { ID = "BalMilktea004", Name = "布丁奶茶", Money1 = 50, Money2 = 60 },
                    new BalMilktea { ID = "BalMilktea005", Name = "懷舊奶茶", Money1 = 45, Money2 = 55 },
                    new BalMilktea { ID = "BalMilktea006", Name = "波樣奶綠", Money1 = 45, Money2 = 55 },
                    new BalMilktea { ID = "BalMilktea007", Name = "沉香烏龍奶", Money1 = 45, Money2 = 55 },
                    new BalMilktea { ID = "BalMilktea008", Name = "焙香麥奶", Money1 = 45, Money2 = 55 }
                );
                modelBuilder.Entity<BalMilk>().HasData(
                    new BalMilk { ID = "BalMilk001", Name = "黑糖珍珠鮮奶", Money1 = 60, Money2 = 75 },
                    new BalMilk { ID = "BalMilk002", Name = "黑糖粉條鮮奶", Money1 = 60, Money2 = 75 },
                    new BalMilk { ID = "BalMilk003", Name = "黑糖珍珠厚奶", Money1 = 65 },
                    new BalMilk { ID = "BalMilk004", Name = "超濃芋鮮奶", Money1 = 65, Money2 = 80 },
                    new BalMilk { ID = "BalMilk005", Name = "黑糖嫩仙草仙奶", Money1 = 60, Money2 = 75 },
                    new BalMilk { ID = "BalMilk006", Name = "手工布丁鮮奶", Money1 = 60, Money2 = 75 },
                    new BalMilk { ID = "BalMilk007", Name = "黑糖鮮奶", Money1 = 60, Money2 = 75 },
                    new BalMilk { ID = "BalMilk008", Name = "珍珠布丁鮮奶", Money1 = 65, Money2 = 80 },
                    new BalMilk { ID = "BalMilk009", Name = "布丁芋頭鮮奶", Money1 = 65, Money2 = 80 }
                ); 
                modelBuilder.Entity<BalCloudcover>().HasData(
                    new BalCloudcover { ID = "BalCloudcover001", Name = "雲蓋烏龍", Money2 = 60 },
                    new BalCloudcover { ID = "BalCloudcover002", Name = "雲蓋青", Money2 = 60 },
                    new BalCloudcover { ID = "BalCloudcover003", Name = "雲蓋綠", Money2 = 60 },
                    new BalCloudcover { ID = "BalCloudcover004", Name = "雲蓋悠娜紅", Money2 = 60 },
                    new BalCloudcover { ID = "BalCloudcover005", Name = "雲蓋菩耳", Money2 = 60 },
                    new BalCloudcover { ID = "BalCloudcover006", Name = "雲蓋桂花烏龍", Money2 = 65 },
                    new BalCloudcover { ID = "BalCloudcover007", Name = "雲蓋泰泰", Money2 = 90 },
                    new BalCloudcover { ID = "BalCloudcover008", Name = "雲蓋阿華田", Money2 = 75 },
                    new BalCloudcover { ID = "BalCloudcover009", Name = "雲蓋冬瓜那堤", Money2 = 90 }
                );
                modelBuilder.Entity<BalThickslices>().HasData(
                    new BalThickslices { ID = "BalThickslices001", Name = "日式鹹奶油", Money = 50 },
                    new BalThickslices { ID = "BalThickslices002", Name = "金黃奶酥", Money = 50 },
                    new BalThickslices { ID = "BalThickslices003", Name = "美式香蒜", Money = 50 },
                    new BalThickslices { ID = "BalThickslices004", Name = "烤糖吐司", Money = 55 }
                );
                modelBuilder.Entity<BalFruity>().HasData(
                    new BalFruity { ID = "BalFruity001", Name = "香橙果綠", Money2 = 75 },
                    new BalFruity { ID = "BalFruity002", Name = "甘蔗青茶", Money2 = 60 },
                    new BalFruity { ID = "BalFruity003", Name = "百香雙Q", Money2 = 55 },
                    new BalFruity { ID = "BalFruity004", Name = "柳橙百香綠", Money2 = 60 },
                    new BalFruity { ID = "BalFruity005", Name = "百香綠", Money2 = 50 },
                    new BalFruity { ID = "BalFruity006", Name = "多多綠茶", Money2 = 55 },
                    new BalFruity { ID = "BalFruity007", Name = "紫蘇梅果綠", Money2 = 55 },
                    new BalFruity { ID = "BalFruity008", Name = "翡翠檸檬", Money2 = 50 },
                    new BalFruity { ID = "BalFruity009", Name = "凍檸紅茶", Money2 = 50 },
                    new BalFruity { ID = "BalFruity010", Name = "百香檸檬", Money2 = 55 },
                    new BalFruity { ID = "BalFruity011", Name = "百香多多", Money2 = 60 }
                );
                modelBuilder.Entity<BalSpecialblend>().HasData(
                    new BalSpecialblend { ID = "BalSpecialblend001", Name = "古早味冬瓜露", Money2 = 35 },
                    new BalSpecialblend { ID = "BalSpecialblend002", Name = "檸檬冬瓜", Money2 = 45 },
                    new BalSpecialblend { ID = "BalSpecialblend003", Name = "阿華田", Money2 = 55 },
                    new BalSpecialblend { ID = "BalSpecialblend004", Name = "檸檬蜜", Money2 = 55 },
                    new BalSpecialblend { ID = "BalSpecialblend005", Name = "蜂蜜菩耳", Money2 = 55 },
                    new BalSpecialblend { ID = "BalSpecialblend006", Name = "桂花烏龍", Money2 = 55 },
                    new BalSpecialblend { ID = "BalSpecialblend007", Name = "桂花菩耳椰", Money2 = 60 }
                );
                modelBuilder.Entity<BalWinterlimited>().HasData(
                    new BalWinterlimited { ID = "BalWinterlimited001", Name = "貴妃奶茶", Money1 = 50 },
                    new BalWinterlimited { ID = "BalWinterlimited002", Name = "貴妃甘茶", Money1 = 40 },
                    new BalWinterlimited { ID = "BalWinterlimited003", Name = "重乳可可奶茶", Money1 = 60, Money2 = 70 },
                    new BalWinterlimited { ID = "BalWinterlimited004", Name = "特濃抹茶那堤", Money1 = 70, Money2 = 80 }
                );
                modelBuilder.Entity<BallsTeaMat>().HasData(
                    new BallsTeaMat { ID = "BallsTeaMat001", TeaMaterialName = "雪耳", Money = 20 },
                    new BallsTeaMat { ID = "BallsTeaMat002", TeaMaterialName = "桂花釀", Money = 20 },
                    new BallsTeaMat { ID = "BallsTeaMat003", TeaMaterialName = "蜂蜜", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat004", TeaMaterialName = "珍珠", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat005", TeaMaterialName = "仙草", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat006", TeaMaterialName = "芋頭", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat007", TeaMaterialName = "布丁", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat008", TeaMaterialName = "椰果", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat009", TeaMaterialName = "綠豆", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat010", TeaMaterialName = "粉條", Money = 10 },
                    new BallsTeaMat { ID = "BallsTeaMat011", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<BallsTeaIce>().HasData(
                    new BallsTeaIce { ID = "BallsTeaIce001", IceName = "正常冰" },
                    new BallsTeaIce { ID = "BallsTeaIce002", IceName = "少冰" },
                    new BallsTeaIce { ID = "BallsTeaIce003", IceName = "微冰" },
                    new BallsTeaIce { ID = "BallsTeaIce004", IceName = "去冰" },
                    new BallsTeaIce { ID = "BallsTeaIce005", IceName = "溫" },
                    new BallsTeaIce { ID = "BallsTeaIce006", IceName = "熱" }
                );
                modelBuilder.Entity<BallsTeaSug>().HasData(
                    new BallsTeaSug { ID = "BallsTeaSug001", SugarName = "全糖" },
                    new BallsTeaSug { ID = "BallsTeaSug002", SugarName = "少糖" },
                    new BallsTeaSug { ID = "BallsTeaSug003", SugarName = "半糖" },
                    new BallsTeaSug { ID = "BallsTeaSug004", SugarName = "微糖" },
                    new BallsTeaSug { ID = "BallsTeaSug005", SugarName = "無糖" }
                );
                //50嵐//
                modelBuilder.Entity<FiftyLanTea>().HasData(
                    new FiftyLanTea { ID = "FiftyLanTea001", Name = "茉莉綠茶", Money1 = 30, Money2 = 35 },
                    new FiftyLanTea { ID = "FiftyLanTea002", Name = "阿薩姆紅茶", Money1 = 30, Money2 = 35 },
                    new FiftyLanTea { ID = "FiftyLanTea003", Name = "四季春青茶", Money1 = 30, Money2 = 35 },
                    new FiftyLanTea { ID = "FiftyLanTea004", Name = "黃金烏龍茶", Money1 = 30, Money2 = 35 },
                    new FiftyLanTea { ID = "FiftyLanTea005", Name = "椰果紅茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea006", Name = "椰果綠茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea007", Name = "椰果青茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea008", Name = "椰果烏茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea009", Name = "波霸紅茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea010", Name = "波霸綠茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea011", Name = "燕麥紅茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea012", Name = "燕麥綠茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea013", Name = "微檸檬紅茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea014", Name = "微檸檬綠茶", Money1 = 35, Money2 = 45 },
                    new FiftyLanTea { ID = "FiftyLanTea015", Name = "檸檬綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea016", Name = "檸檬青茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea017", Name = "梅の綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea018", Name = "8冰綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea019", Name = "情人茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea020", Name = "多多綠", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea021", Name = "冰淇淋紅茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea022", Name = "旺來紅茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea023", Name = "旺來綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea024", Name = "旺來青茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea025", Name = "柚子紅茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea026", Name = "柚子綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea027", Name = "柚子青茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea028", Name = "柚子烏茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea029", Name = "奶茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea030", Name = "綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea031", Name = "烏龍奶茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea032", Name = "奶青茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea033", Name = "椰果奶茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea034", Name = "珍珠奶茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea035", Name = "波霸奶茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea036", Name = "燕麥奶茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea037", Name = "布丁奶茶", Money1 = 50, Money2 = 65 },
                    new FiftyLanTea { ID = "FiftyLanTea038", Name = "冰淇淋奶茶", Money1 = 50, Money2 = 65 },
                    new FiftyLanTea { ID = "FiftyLanTea039", Name = "紅茶瑪奇朵(鮮奶油)", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea040", Name = "青茶瑪奇朵(鮮奶油)", Money1 = 40, Money2 = 55 },
                    new FiftyLanTea { ID = "FiftyLanTea041", Name = "阿華田", Money1 = 45, Money2 = 60 },
                    new FiftyLanTea { ID = "FiftyLanTea042", Name = "可可芭蕾", Money1 = 50, Money2 = 65 }
                );
                modelBuilder.Entity<FiftyLanLatte>().HasData(
                    new FiftyLanLatte { ID = "FiftyLanLatte001", Name = "紅茶拿鐵", Money1 = 50, Money2 = 65 },
                    new FiftyLanLatte { ID = "FiftyLanLatte002", Name = "綠茶拿鐵", Money1 = 50, Money2 = 65 },
                    new FiftyLanLatte { ID = "FiftyLanLatte003", Name = "烏龍拿鐵", Money1 = 50, Money2 = 65 },
                    new FiftyLanLatte { ID = "FiftyLanLatte004", Name = "珍珠紅茶拿鐵", Money1 = 50, Money2 = 65 },
                    new FiftyLanLatte { ID = "FiftyLanLatte005", Name = "波霸紅茶拿鐵", Money1 = 50, Money2 = 65 },
                    new FiftyLanLatte { ID = "FiftyLanLatte006", Name = "燕麥紅茶拿鐵", Money1 = 50, Money2 = 65 },
                    new FiftyLanLatte { ID = "FiftyLanLatte007", Name = "布丁紅茶拿鐵", Money1 = 55, Money2 = 75 },
                    new FiftyLanLatte { ID = "FiftyLanLatte008", Name = "冰淇淋紅茶拿鐵", Money1 = 55, Money2 = 75 },
                    new FiftyLanLatte { ID = "FiftyLanLatte009", Name = "阿華田拿鐵", Money1 = 55, Money2 = 75 },
                    new FiftyLanLatte { ID = "FiftyLanLatte010", Name = "可可芭蕾拿鐵", Money1 = 55, Money2 = 75 }
                ); modelBuilder.Entity<FiftyLanFresh>().HasData(
                    new FiftyLanFresh { ID = "FiftyLanFresh001", Name = "柚子茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanFresh { ID = "FiftyLanFresh002", Name = "8冰茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanFresh { ID = "FiftyLanFresh003", Name = "檸檬汁", Money1 = 50, Money2 = 65 },
                    new FiftyLanFresh { ID = "FiftyLanFresh004", Name = "金桔檸檬", Money1 = 50, Money2 = 65 },
                    new FiftyLanFresh { ID = "FiftyLanFresh005", Name = "檸檬梅汁", Money1 = 50, Money2 = 65 },
                    new FiftyLanFresh { ID = "FiftyLanFresh006", Name = "檸檬多多", Money1 = 55, Money2 = 75 }
                ); modelBuilder.Entity<FiftyLanSeasonal>().HasData(
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal001", Name = "蜜蜂綠茶", Money1 = 40, Money2 = 55 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal002", Name = "蜜蜂奶茶", Money1 = 50, Money2 = 65 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal003", Name = "鮮柚綠茶", Money1 = 50, Money2 = 65 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal004", Name = "葡萄柚汁", Money1 = 50, Money2 = 65 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal005", Name = "檸檬蜜", Money1 = 55, Money2 = 75 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal006", Name = "金桔檸檬蜜", Money1 = 55, Money2 = 75 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal007", Name = "葡萄柚蜜", Money1 = 55, Money2 = 75 },
                    new FiftyLanSeasonal { ID = "FiftyLanSeasonal008", Name = "葡萄柚多多", Money1 = 55, Money2 = 75 }
                );
                modelBuilder.Entity<FiftyLanMat>().HasData(
                    new FiftyLanMat { ID = "FiftyLanMat001", TeaMaterialName = "珍珠", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat002", TeaMaterialName = "波霸", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat003", TeaMaterialName = "椰果", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat004", TeaMaterialName = "混珠", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat005", TeaMaterialName = "珍波椰", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat006", TeaMaterialName = "布丁", Money = 10 },
                    new FiftyLanMat { ID = "FiftyLanMat007", TeaMaterialName = "珍椰", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat008", TeaMaterialName = "波椰", Money = 0 },
                    new FiftyLanMat { ID = "FiftyLanMat009", TeaMaterialName = "無", Money = 0 }
               );
                modelBuilder.Entity<FiftyLanIce>().HasData(
                    new FiftyLanIce { ID = "FiftyLanIce001", IceName = "正常冰" },
                    new FiftyLanIce { ID = "FiftyLanIce002", IceName = "少冰" },
                    new FiftyLanIce { ID = "FiftyLanIce003", IceName = "微冰" },
                    new FiftyLanIce { ID = "FiftyLanIce004", IceName = "去冰" },
                    new FiftyLanIce { ID = "FiftyLanIce005", IceName = "溫" },
                    new FiftyLanIce { ID = "FiftyLanIce006", IceName = "熱" }
                );
                modelBuilder.Entity<FiftyLanSug>().HasData(
                    new FiftyLanSug { ID = "FiftyLanSug001", SugarName = "全糖" },
                    new FiftyLanSug { ID = "FiftyLanSug002", SugarName = "少糖" },
                    new FiftyLanSug { ID = "FiftyLanSug003", SugarName = "半糖" },
                    new FiftyLanSug { ID = "FiftyLanSug004", SugarName = "微糖" },
                    new FiftyLanSug { ID = "FiftyLanSug005", SugarName = "無糖" }
                );
                //LIKEFANG//
                modelBuilder.Entity<LIKEFANGThickMilkCover>().HasData(
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover001", Name = "厚奶蓋紅茶", Money1 = 45, Money2 = 50 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover002", Name = "厚奶蓋綠茶", Money1 = 45, Money2 = 50 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover003", Name = "厚奶蓋青茶", Money1 = 50, Money2 = 55 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover004", Name = "厚奶蓋格雷", Money1 = 50, Money2 = 55 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover005", Name = "厚奶蓋奶茶", Money1 = 60, Money2 = 70 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover006", Name = "厚奶蓋鮮奶茶", Money1 = 65, Money2 = 75 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover007", Name = "厚奶蓋黑糖珍奶", Money1 = 55, Money2 = 65 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover008", Name = "厚奶蓋濃情可可", Money2 = 85 },
                    new LIKEFANGThickMilkCover { ID = "LIKEFANGThickMilkCover009", Name = "厚奶蓋靜岡抹茶", Money2 = 85 }
                );
                modelBuilder.Entity<LIKEFANGFreshMilkTea>().HasData(
                    new LIKEFANGFreshMilkTea { ID = "LIKEFANGFreshMilkTea001", Name = "經典鮮奶茶", Money1 = 55, Money2 = 65 },
                    new LIKEFANGFreshMilkTea { ID = "LIKEFANGFreshMilkTea002", Name = "紅茶鮮奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGFreshMilkTea { ID = "LIKEFANGFreshMilkTea003", Name = "格雷鮮奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGFreshMilkTea { ID = "LIKEFANGFreshMilkTea004", Name = "小葉綠鮮奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGFreshMilkTea { ID = "LIKEFANGFreshMilkTea005", Name = "大禹嶺鮮奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGFreshMilkTea { ID = "LIKEFANGFreshMilkTea006", Name = "OREO鮮奶茶", Money1 = 55, Money2 = 65 }
                );
                modelBuilder.Entity<LIKEFANGBrownSugar>().HasData(
                    new LIKEFANGBrownSugar { ID = "LIKEFANGBrownSugar001", Name = "黑糖珍珠奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGBrownSugar { ID = "LIKEFANGBrownSugar002", Name = "黑糖珍珠鮮奶", Money1 = 60, Money2 = 75 },
                    new LIKEFANGBrownSugar { ID = "LIKEFANGBrownSugar003", Name = "黑糖珍珠可可鮮奶", Money1 = 60, Money2 = 80 },
                    new LIKEFANGBrownSugar { ID = "LIKEFANGBrownSugar004", Name = "黑糖珍珠抹茶鮮奶", Money1 = 60, Money2 = 80 }
                );
                modelBuilder.Entity<LIKEFANGFreshFruit> ().HasData(
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit001", Name = "冬瓜檸檬", Money2 = 50 },
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit002", Name = "甘蔗清茶", Money2 = 60 },
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit003", Name = "甘蔗檸檬", Money2 = 60 },
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit004", Name = "清檸芭樂", Money2 = 60 },
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit005", Name = "百香QQ綠", Money2 = 55 },
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit006", Name = "鮮百香綠茶", Money2 = 50 },
                    new LIKEFANGFreshFruit { ID = "LIKEFANGFreshFruit007", Name = "旺來百香綠", Money2 = 60 }
                );
                modelBuilder.Entity<LIKEFANGSpecialBlend>().HasData(
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend001", Name = "綠豆沙", Money2 = 45 },
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend002", Name = "多多綠茶", Money2 = 50 },
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend003", Name = "綠豆沙牛奶", Money2 = 55 },
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend004", Name = "港式檸檬奶", Money2 = 60 },
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend005", Name = "蜂蜜蘋果醋飲", Money2 = 50 },
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend006", Name = "翡翠檸檬紅茶", Money2 = 50 },
                    new LIKEFANGSpecialBlend { ID = "LIKEFANGSpecialBlend007", Name = "翡翠檸檬綠茶", Money2 = 50 }
                );
                modelBuilder.Entity<LIKEFANGKitKat>().HasData(
                    new LIKEFANGKitKat { ID = "LIKEFANGKitKat001", Name = "幸運奶茶", Money2 = 55 },
                    new LIKEFANGKitKat { ID = "LIKEFANGKitKat002", Name = "滿分草莓", Money2 = 90 },
                    new LIKEFANGKitKat { ID = "LIKEFANGKitKat003", Name = "幸運鮮奶茶", Money2 = 65 },
                    new LIKEFANGKitKat { ID = "LIKEFANGKitKat004", Name = "元氣奇異果", Money2 = 90 },
                    new LIKEFANGKitKat { ID = "LIKEFANGKitKat005", Name = "勝利法芙娜", Money2 = 90 }
                );
                modelBuilder.Entity<LIKEFANGMilkTea>().HasData(
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea001", Name = "手作奶茶", Money1 = 40, Money2 = 50 },
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea002", Name = "格雷奶茶", Money1 = 40, Money2 = 50 },
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea003", Name = "珍珠奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea004", Name = "可可奶茶", Money1 = 45, Money2 = 55 },
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea005", Name = "經典奶茶", Money1 = 50, Money2 = 60 },
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea006", Name = "小葉綠奶茶", Money1 = 40, Money2 = 50 },
                    new LIKEFANGMilkTea { ID = "LIKEFANGMilkTea007", Name = "OREO奶茶", Money1 = 45, Money2 = 55 }
                );
                modelBuilder.Entity<LIKEFANGTea>().HasData(
                    new LIKEFANGTea { ID = "LIKEFANGTea001", Name = "冬瓜茶", Money1 = 30, Money2 = 35 },
                    new LIKEFANGTea { ID = "LIKEFANGTea002", Name = "小葉綠茶", Money1 = 25, Money2 = 30 },
                    new LIKEFANGTea { ID = "LIKEFANGTea003", Name = "格雷紅茶", Money1 = 30, Money2 = 35 },
                    new LIKEFANGTea { ID = "LIKEFANGTea004", Name = "仙草甘茶", Money1 = 30, Money2 = 35 },
                    new LIKEFANGTea { ID = "LIKEFANGTea005", Name = "大禹嶺清茶", Money1 = 30, Money2 = 35 },
                    new LIKEFANGTea { ID = "LIKEFANGTea006", Name = "斯里蘭卡紅茶", Money1 = 25, Money2 = 30 }
                );
                modelBuilder.Entity<LIKEFANGMat>().HasData(
                    new LIKEFANGMat { ID = "LIKEFANGMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new LIKEFANGMat { ID = "LIKEFANGMat002", TeaMaterialName = "蒟蒻", Money = 10 },
                    new LIKEFANGMat { ID = "LIKEFANGMat003", TeaMaterialName = "椰果", Money = 10 },
                    new LIKEFANGMat { ID = "LIKEFANGMat004", TeaMaterialName = "OREO", Money = 10 },
                    new LIKEFANGMat { ID = "LIKEFANGMat005", TeaMaterialName = "LitKat", Money = 15 },
                    new LIKEFANGMat { ID = "LIKEFANGMat006", TeaMaterialName = "黑糖珍珠", Money = 15 },
                    new LIKEFANGMat { ID = "LIKEFANGMat007", TeaMaterialName = "經典(珍珠+蒟蒻+椰果)", Money = 15 },
                    new LIKEFANGMat { ID = "LIKEFANGMat008", TeaMaterialName = "厚奶蓋", Money = 20 },
                    new LIKEFANGMat { ID = "LIKEFANGMat009", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<LIKEFANGIce>().HasData(
                    new LIKEFANGIce { ID = "LIKEFANGIce001", IceName = "正常" },
                    new LIKEFANGIce { ID = "LIKEFANGIce002", IceName = "少冰" },
                    new LIKEFANGIce { ID = "LIKEFANGIce003", IceName = "微冰" },
                    new LIKEFANGIce { ID = "LIKEFANGIce004", IceName = "去冰" },
                    new LIKEFANGIce { ID = "LIKEFANGIce005", IceName = "常溫" },
                    new LIKEFANGIce { ID = "LIKEFANGIce006", IceName = "熱" }
                );
                modelBuilder.Entity<LIKEFANGSug>().HasData(
                    new LIKEFANGSug { ID = "LIKEFANGSug001", SugarName = "全糖" },
                    new LIKEFANGSug { ID = "LIKEFANGSug002", SugarName = "少糖" },
                    new LIKEFANGSug { ID = "LIKEFANGSug003", SugarName = "半糖" },
                    new LIKEFANGSug { ID = "LIKEFANGSug004", SugarName = "微糖" },
                    new LIKEFANGSug { ID = "LIKEFANGSug005", SugarName = "無糖" }
                );
                //COMEBUY//
                modelBuilder.Entity<COMEBUYOriginalLeaves>().HasData(
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves001", Name = "鮮萃大麥紅茶 (本產品含有麩質之穀物製品)", Money2 = 35 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves002", Name = "碧螺春", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves003", Name = "四季春", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves004", Name = "玫瑰普洱", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves005", Name = "烏龍綠茶 (100%台灣茶)", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves006", Name = "茉莉烏龍 (100%台灣茶)", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves007", Name = "斯里蘭卡烏瓦紅茶", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves008", Name = "海神", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves009", Name = "熟滄觀音 (100%台灣茶)", Money2 = 40 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves010", Name = "文山包種 (100%台灣茶)", Money2 = 50 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves011", Name = "東方美人 (100%台灣茶)", Money2 = 50 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves012", Name = "白桃蜜烏龍", Money2 = 50 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves013", Name = "洛神蜜香紅茶", Money2 = 50 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves014", Name = "桂花四季春", Money2 = 50 },
                    new COMEBUYOriginalLeaves { ID = "COMEBUYOriginalLeaves015", Name = "柑橘金萱", Money2 = 55 }
                );
                modelBuilder.Entity<COMEBUYFreshTeaLatte>().HasData(
                    new COMEBUYFreshTeaLatte { ID = "COMEBUYFreshTeaLatte001", Name = "紅茶拿鐵", Money1 = 55, Money2 = 60 },
                    new COMEBUYFreshTeaLatte { ID = "COMEBUYFreshTeaLatte002", Name = "烏龍拿鐵 (100%台灣茶)", Money2 = 60 },
                    new COMEBUYFreshTeaLatte { ID = "COMEBUYFreshTeaLatte003", Name = "四季春拿鐵", Money2 = 60 },
                    new COMEBUYFreshTeaLatte { ID = "COMEBUYFreshTeaLatte004", Name = "金萱拿鐵", Money2 = 60 },
                    new COMEBUYFreshTeaLatte { ID = "COMEBUYFreshTeaLatte005", Name = "觀音拿鐵 (100%台灣茶)", Money2 = 60 }
                );
                modelBuilder.Entity<COMEBUYFreshFruitTea>().HasData(
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea001", Name = "錫蘭紅茶", Money1 = 25, Money2 = 30 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea002", Name = "茉莉綠茶", Money1 = 25, Money2 = 30 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea003", Name = "蜂蜜紅茶", Money1 = 40, Money2 = 45 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea004", Name = "蜂蜜綠茶", Money1 = 40, Money2 = 45 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea005", Name = "玉荷冰綠", Money2 = 45 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea006", Name = "檸檬冰茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea007", Name = "梅果茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea008", Name = "養樂多綠茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea009", Name = "百香搖果樂", Money1 = 45, Money2 = 50 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea010", Name = "蘋果冰茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea011", Name = "葡萄柚綠茶", Money2 = 60 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea012", Name = "鳳梨冰茶", Money2 = 60 },
                    new COMEBUYFreshFruitTea { ID = "COMEBUYFreshFruitTea013", Name = "芭C檸檬綠(建議半糖少冰以上)", Money1 = 55, Money2 = 60 }
                );
                modelBuilder.Entity<COMEBUYReally>().HasData(
                    new COMEBUYReally { ID = "LIKEFANGFreshFruit001", Name = "超桔霸氣飲", Money2 = 45 },
                    new COMEBUYReally { ID = "LIKEFANGFreshFruit002", Name = "蜂蜜蘆薈", Money1 = 40, Money2 = 45 },
                    new COMEBUYReally { ID = "LIKEFANGFreshFruit003", Name = "金桔檸檬", Money1 = 45, Money2 = 50 },
                    new COMEBUYReally { ID = "LIKEFANGFreshFruit004", Name = "荔枝玉露", Money1 = 45, Money2 = 50 },
                    new COMEBUYReally { ID = "LIKEFANGFreshFruit005", Name = "纖美小紫蘇", Money2 = 60 },
                    new COMEBUYReally { ID = "LIKEFANGFreshFruit006", Name = "芭C檸檬多多 (不提供去冰)", Money1 = 60, Money2 = 80 }
                );
                modelBuilder.Entity<COMEBUYSummerOnly> ().HasData(
                    new COMEBUYSummerOnly { ID = "LIKEFANGSpecialBlend001", Name = "檸檬愛玉", Money2 = 50 },
                    new COMEBUYSummerOnly { ID = "LIKEFANGSpecialBlend002", Name = "百香果冰沙", Money2 = 50 },
                    new COMEBUYSummerOnly { ID = "LIKEFANGSpecialBlend003", Name = "七巧歐蕾 (本產品含有花生、牛奶製品)", Money2 = 60 },
                    new COMEBUYSummerOnly { ID = "LIKEFANGSpecialBlend004", Name = "金芒果優酪 (本產品含有花生、牛奶製品)", Money2 = 60 },
                    new COMEBUYSummerOnly { ID = "LIKEFANGSpecialBlend005", Name = "青檸香柚QQ", Money2 = 70 }
                );
                modelBuilder.Entity<COMEBUYMilkTeaCocoa>().HasData(
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa001", Name = "招牌奶茶", Money1 = 40, Money2 = 45 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa002", Name = "黃金奶綠", Money1 = 40, Money2 = 45 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa003", Name = "珍珠奶茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa004", Name = "鮮萃大麥奶茶 (本產品含有麩質之穀物製品)", Money2 = 50 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa005", Name = "海神奶茶", Money2 = 55 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa006", Name = "絕代雙Q奶茶 (+15元升級鮮奶茶)", Money1 = 50, Money2 = 55 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa007", Name = "仙草凍奶茶 (+15元升級鮮奶)", Money2 = 60 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa008", Name = "桂花奶綠", Money1 = 55, Money2 = 60 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa009", Name = "港式厚奶", Money1 = 65 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa010", Name = "觀音厚奶", Money1 = 65 },
                    new COMEBUYMilkTeaCocoa { ID = "COMEBUYMilkTeaCocoa011", Name = "經典可可 (+15元升級鮮奶)", Money1 = 40, Money2 = 45 }
                );
                modelBuilder.Entity<COMEBUYSpecialCoffee>().HasData(
                    new COMEBUYSpecialCoffee { ID = "COMEBUYSpecialCoffee001", Name = "特調咖啡", Money1 = 40, Money2 = 45 }
                );
                modelBuilder.Entity<COMEBUYWinterOnly> ().HasData(
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly001", Name = "桂圓紅棗", Money2 = 40 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly002", Name = "暖薑茶", Money2 = 40 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly003", Name = "暖薑奶茶", Money2 = 50 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly004", Name = "熱檸茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly005", Name = "熱桔茶", Money1 = 45, Money2 = 50 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly006", Name = "黑糖薑汁可可", Money2 = 55 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly007", Name = "紫米可可", Money1 = 50, Money2 = 55 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly008", Name = "紫米奶茶", Money1 = 50, Money2 = 55 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly009", Name = "宇治抹茶", Money1 = 60 },
                    new COMEBUYWinterOnly { ID = "COMEBUYWinterOnly010", Name = "抹茶拿鐵", Money1 = 60, Money2 = 80 }
                );
                modelBuilder.Entity<COMEBUYMat>().HasData(
                    new COMEBUYMat { ID = "COMEBUYMat001", TeaMaterialName = "珍珠", Money = 5 },
                    new COMEBUYMat { ID = "COMEBUYMat002", TeaMaterialName = "小紫蘇", Money = 5 },
                    new COMEBUYMat { ID = "COMEBUYMat003", TeaMaterialName = "新雙Q(珍珠 + 芋圓 + 薯圓)", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat004", TeaMaterialName = "小芋圓(芋圓 + 薯圓)", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat005", TeaMaterialName = "粉條", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat006", TeaMaterialName = "搖果樂(珍珠 + 椰果 + 荔枝凍)", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat007", TeaMaterialName = "愛玉", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat008", TeaMaterialName = "蘆薈", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat009", TeaMaterialName = "紫米(季節限定)", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat010", TeaMaterialName = "紅豆(季節限定)", Money = 10 },
                    new COMEBUYMat { ID = "COMEBUYMat011", TeaMaterialName = "仙草凍", Money = 15 },
                    new COMEBUYMat { ID = "COMEBUYMat012", TeaMaterialName = "布丁", Money = 15 },
                    new COMEBUYMat { ID = "COMEBUYMat013", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<COMEBUYIce>().HasData(
                    new COMEBUYIce { ID = "COMEBUYIce001", IceName = "標準冰" },
                    new COMEBUYIce { ID = "COMEBUYIce002", IceName = "少冰" }
                );
                modelBuilder.Entity<COMEBUYSug>().HasData(
                    new COMEBUYSug { ID = "COMEBUYSug001", SugarName = "標準糖" },
                    new COMEBUYSug { ID = "COMEBUYSug002", SugarName = "少糖" },
                    new COMEBUYSug { ID = "COMEBUYSug003", SugarName = "半糖" },
                    new COMEBUYSug { ID = "COMEBUYSug005", SugarName = "無糖" }
                );
                //金茶伍//
                modelBuilder.Entity<JinchaWuQKueh>().HasData(
                    new JinchaWuQKueh { ID = "JinchaWuQKueh001", Name = "Q粿紅茶", Money = 40 },
                    new JinchaWuQKueh { ID = "JinchaWuQKueh002", Name = "Q粿蕎麥厚奶", Money = 35 },
                    new JinchaWuQKueh { ID = "JinchaWuQKueh003", Name = "Q粿厚奶", Money = 35 },
                    new JinchaWuQKueh { ID = "JinchaWuQKueh004", Name = "柳丁Q粿果粒茶", Money = 35 },
                    new JinchaWuQKueh { ID = "JinchaWuQKueh005", Name = "荔枝Q粿果粒茶", Money = 35 },
                    new JinchaWuQKueh { ID = "JinchaWuQKueh006", Name = "紅柚Q粿果粒茶", Money = 35 }
                );
                modelBuilder.Entity<JinchaWuGoldenGoodTea>().HasData(
                    new JinchaWuGoldenGoodTea { ID = "JinchaWuGoldenGoodTea001", Name = "金青茶王", Money = 55 },
                    new JinchaWuGoldenGoodTea { ID = "JinchaWuGoldenGoodTea002", Name = "冬採四季青", Money = 60 },
                    new JinchaWuGoldenGoodTea { ID = "JinchaWuGoldenGoodTea003", Name = "日光金萱", Money = 65 },
                    new JinchaWuGoldenGoodTea { ID = "JinchaWuGoldenGoodTea004", Name = "金牌紅茶", Money = 55 },
                    new JinchaWuGoldenGoodTea { ID = "JinchaWuGoldenGoodTea005", Name = "清新小茉綠", Money = 60 }
                );
                modelBuilder.Entity<JinchaWuGoldenFresh>().HasData(
                    new JinchaWuGoldenFresh { ID = "JinchaWuGoldenFresh001", Name = "紅蔗青茶", Money = 60 },
                    new JinchaWuGoldenFresh { ID = "JinchaWuGoldenFresh002", Name = "翡翠鮮檸", Money = 60 },
                    new JinchaWuGoldenFresh { ID = "JinchaWuGoldenFresh003", Name = "紅柚果果粒", Money = 55 },
                    new JinchaWuGoldenFresh { ID = "JinchaWuGoldenFresh004", Name = "柳丁果果粒 (台灣柳丁)", Money = 55 }
                );
                modelBuilder.Entity<JinchaWuKimHougong>().HasData(
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong001", Name = "金紅拿鐵", Money = 50 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong002", Name = "砲彈金紅拿鐵", Money = 60 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong003", Name = "醇濃厚奶", Money = 50 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong004", Name = "砲彈厚奶", Money = 65 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong005", Name = "奶蓋金紅", Money = 65 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong006", Name = "梅釀小茉綠", Money = 50 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong007", Name = "多多翠綠", Money = 65 },
                    new JinchaWuKimHougong { ID = "JinchaWuKimHougong008", Name = "綠豆沙牛奶 (固定甜度與冰量)", Money = 50 }
                );
                modelBuilder.Entity<JinchaWuJinHaomian>().HasData(
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian001", Name = "黃金蕎麥茶", Money = 65 },
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian002", Name = "蕎麥厚奶", Money = 65 },
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian003", Name = "蕎麥拿鐵", Money = 65 },
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian004", Name = "冰糖菊花", Money = 65 },
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian005", Name = "冬露菊花 (固定甜度)", Money = 65 },
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian006", Name = "憨厚冬瓜 (固定甜度)", Money = 65 },
                    new JinchaWuJinHaomian { ID = "JinchaWuJinHaomian007", Name = "冬檸冰茶 (固定甜度)", Money = 65 }
                );
                modelBuilder.Entity<JinchaWuJinYoumi>().HasData(
                    new JinchaWuJinYoumi { ID = "JinchaWuJinYoumi001", Name = "百花蜜綠 (固定甜度)", Money = 65 },
                    new JinchaWuJinYoumi { ID = "JinchaWuJinYoumi002", Name = "秋菊香蜜 (固定甜度)", Money = 65 },
                    new JinchaWuJinYoumi { ID = "JinchaWuJinYoumi003", Name = "蜂蜜鮮檸 (固定甜度)", Money = 65 },
                    new JinchaWuJinYoumi { ID = "JinchaWuJinYoumi004", Name = "粒粒蜜紅柚 (固定甜度)", Money = 65 }
                );
                modelBuilder.Entity<JinchaWuMat>().HasData(
                    new JinchaWuMat { ID = "JinchaWuMat001", TeaMaterialName = "砲彈(份)", Money = 10 },
                    new JinchaWuMat { ID = "JinchaWuMat002", TeaMaterialName = "純蜜Q粿(份)", Money = 15 },
                    new JinchaWuMat { ID = "JinchaWuMat003", TeaMaterialName = "水果Q粿(份)", Money = 20 },
                    new JinchaWuMat { ID = "JinchaWuMat004", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<JinchaWuIce>().HasData(
                    new JinchaWuIce { ID = "JinchaWuIce001", IceName = "正常冰(100%)" },
                    new JinchaWuIce { ID = "JinchaWuIce002", IceName = "半冰(50%)" },
                    new JinchaWuIce { ID = "JinchaWuIce003", IceName = "微冰(30%)" },
                    new JinchaWuIce { ID = "JinchaWuIce004", IceName = "去冰(0%)" }
                );
                modelBuilder.Entity<JinchaWuSug>().HasData(
                    new JinchaWuSug { ID = "JinchaWuSug001", SugarName = "全糖(100%)" },
                    new JinchaWuSug { ID = "JinchaWuSug002", SugarName = "少糖(80%)" },
                    new JinchaWuSug { ID = "JinchaWuSug003", SugarName = "半糖(50%)" },
                    new JinchaWuSug { ID = "JinchaWuSug004", SugarName = "微糖(30%)" },
                    new JinchaWuSug { ID = "JinchaWuSug005", SugarName = "兩分糖(20%)" },
                    new JinchaWuSug { ID = "JinchaWuSug006", SugarName = "一分糖(10%)" },
                    new JinchaWuSug { ID = "JinchaWuSug007", SugarName = "無糖(0%)" }
                );
                //自己來紅茶鮮乳//
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkFreshMilkTea> ().HasData(
                    new MakeYourOwnBlackTeaMilkFreshMilkTea { ID = "MakeYourOwnBlackTeaMilkFreshMilkTea001", Name = "古早味紅茶鮮乳(正常甜)", Money = 55 },
                    new MakeYourOwnBlackTeaMilkFreshMilkTea { ID = "MakeYourOwnBlackTeaMilkFreshMilkTea002", Name = "金典味紅茶鮮乳(微甜)", Money = 55 },
                    new MakeYourOwnBlackTeaMilkFreshMilkTea { ID = "MakeYourOwnBlackTeaMilkFreshMilkTea003", Name = "茉香綠茶鮮乳", Money = 55 },
                    new MakeYourOwnBlackTeaMilkFreshMilkTea { ID = "MakeYourOwnBlackTeaMilkFreshMilkTea004", Name = "黑糖冬瓜鮮乳", Money = 55 },
                    new MakeYourOwnBlackTeaMilkFreshMilkTea { ID = "MakeYourOwnBlackTeaMilkFreshMilkTea005", Name = "炭焙烏龍鮮乳", Money = 55 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkbreasts>().HasData(
                    new MakeYourOwnBlackTeaMilkbreasts { ID = "MakeYourOwnBlackTeabreasts001", Name = "古早味紅茶牛羊乳", Money = 60 },
                    new MakeYourOwnBlackTeaMilkbreasts { ID = "MakeYourOwnBlackTeabreasts002", Name = "金典味紅茶牛羊乳", Money = 60 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkFreshSheep>().HasData(
                    new MakeYourOwnBlackTeaMilkFreshSheep { ID = "MakeYourOwnBlackTeaMilkFreshSheep001", Name = "古早味紅茶羊乳(正常甜)", Money = 60 },
                    new MakeYourOwnBlackTeaMilkFreshSheep { ID = "MakeYourOwnBlackTeaMilkFreshSheep002", Name = "金典味紅茶羊乳(微甜)", Money = 60 },
                    new MakeYourOwnBlackTeaMilkFreshSheep { ID = "MakeYourOwnBlackTeaMilkFreshSheep003", Name = "茉香綠茶羊乳", Money = 60 },
                    new MakeYourOwnBlackTeaMilkFreshSheep { ID = "MakeYourOwnBlackTeaMilkFreshSheep004", Name = "黑糖冬瓜羊乳", Money = 60 },
                    new MakeYourOwnBlackTeaMilkFreshSheep { ID = "MakeYourOwnBlackTeaMilkFreshSheep005", Name = "炭焙烏龍羊乳", Money = 60 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkGoodTea>().HasData(
                    new MakeYourOwnBlackTeaMilkGoodTea { ID = "MakeYourOwnBlackTeaMilkGoodTea001", Name = "古早味紅茶 正常甜", Money = 30 },
                    new MakeYourOwnBlackTeaMilkGoodTea { ID = "MakeYourOwnBlackTeaMilkGoodTea002", Name = "金典味紅茶 微甜", Money = 30 },
                    new MakeYourOwnBlackTeaMilkGoodTea { ID = "MakeYourOwnBlackTeaMilkGoodTea003", Name = "茉香綠茶", Money = 30 },
                    new MakeYourOwnBlackTeaMilkGoodTea { ID = "MakeYourOwnBlackTeaMilkGoodTea004", Name = "黑糖冬瓜茶", Money = 30 },
                    new MakeYourOwnBlackTeaMilkGoodTea { ID = "MakeYourOwnBlackTeaMilkGoodTea005", Name = "仙草甘茶", Money = 30 },
                    new MakeYourOwnBlackTeaMilkGoodTea { ID = "MakeYourOwnBlackTeaMilkGoodTea006", Name = "炭焙烏龍茶", Money = 30 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkCheeseMilkCap>().HasData(
                    new MakeYourOwnBlackTeaMilkCheeseMilkCap { ID = "MakeYourOwnBlackTeaMilkCheeseMilkCap001", Name = "紅茶芝芝", Money = 60 },
                    new MakeYourOwnBlackTeaMilkCheeseMilkCap { ID = "MakeYourOwnBlackTeaMilkCheeseMilkCap002", Name = "綠茶芝芝", Money = 60 },
                    new MakeYourOwnBlackTeaMilkCheeseMilkCap { ID = "MakeYourOwnBlackTeaMilkCheeseMilkCap003", Name = "冬瓜芝芝", Money = 60 },
                    new MakeYourOwnBlackTeaMilkCheeseMilkCap { ID = "MakeYourOwnBlackTeaMilkCheeseMilkCap004", Name = "仙草芝芝", Money = 60 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkFreshlySqueezed>().HasData(
                    new MakeYourOwnBlackTeaMilkFreshlySqueezed { ID = "MakeYourOwnBlackTeaMilkFreshlySqueezed001", Name = "檸檬古早味紅茶", Money = 45 },
                    new MakeYourOwnBlackTeaMilkFreshlySqueezed { ID = "MakeYourOwnBlackTeaMilkFreshlySqueezed002", Name = "檸檬金典味紅茶", Money = 45 },
                    new MakeYourOwnBlackTeaMilkFreshlySqueezed { ID = "MakeYourOwnBlackTeaMilkFreshlySqueezed003", Name = "檸檬茉香綠茶", Money = 45 },
                    new MakeYourOwnBlackTeaMilkFreshlySqueezed { ID = "MakeYourOwnBlackTeaMilkFreshlySqueezed004", Name = "檸檬黑糖冬瓜", Money = 45 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkSoyMilk>().HasData(
                    new MakeYourOwnBlackTeaMilkSoyMilk { ID = "ANiWinterMelonTea001", Name = "冬瓜豆漿", Money = 45 },
                    new MakeYourOwnBlackTeaMilkSoyMilk { ID = "ANiWinterMelonTea002", Name = "紅茶豆漿", Money = 45 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkMat>().HasData(
                    new MakeYourOwnBlackTeaMilkMat { ID = "MakeYourOwnBlackTeaMilkMat001", TeaMaterialName = "銀耳晶露(限好茶系列可加)", Money = 40 },
                    new MakeYourOwnBlackTeaMilkMat { ID = "MakeYourOwnBlackTeaMilkMat002", TeaMaterialName = "黑糖珍珠(鮮牛系列)", Money = 5 },
                    new MakeYourOwnBlackTeaMilkMat { ID = "MakeYourOwnBlackTeaMilkMat003", TeaMaterialName = "黑糖珍珠(鮮羊系列)", Money = 0 },
                    new MakeYourOwnBlackTeaMilkMat { ID = "MakeYourOwnBlackTeaMilkMat004", TeaMaterialName = "黑糖珍珠(好茶系列)", Money = 10 },
                    new MakeYourOwnBlackTeaMilkMat { ID = "MakeYourOwnBlackTeaMilkMat005", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkIce>().HasData(
                    new MakeYourOwnBlackTeaMilkIce { ID = "ANiceholidayIce001", IceName = "無法調整" }
                );
                modelBuilder.Entity<MakeYourOwnBlackTeaMilkSug>().HasData(
                    new MakeYourOwnBlackTeaMilkSug { ID = "ANiceholidaySug001", SugarName = "無法調整" }
                );
                //黃記茶莊//
                modelBuilder.Entity<WongKeeTeaHouseTea>().HasData(
                    new WongKeeTeaHouseTea { ID = "WongKeeTeaHouseTea001", Name = "紅茶", Money1 = 25, Money2 = 30 },
                    new WongKeeTeaHouseTea { ID = "WongKeeTeaHouseTea002", Name = "綠茶", Money1 = 25, Money2 = 30 },
                    new WongKeeTeaHouseTea { ID = "WongKeeTeaHouseTea003", Name = "烏龍茶", Money1 = 25, Money2 = 30 },
                    new WongKeeTeaHouseTea { ID = "WongKeeTeaHouseTea004", Name = "冬瓜茶", Money1 = 30, Money2 = 35 },
                    new WongKeeTeaHouseTea { ID = "WongKeeTeaHouseTea005", Name = "吾優茶 (烏龍茶配綠茶=吾優)", Money1 = 25, Money2 = 30 },
                    new WongKeeTeaHouseTea { ID = "WongKeeTeaHouseTea006", Name = "真美麗(紅茶配綠茶=真美麗)", Money1 = 25, Money2 = 30 }
                );
                modelBuilder.Entity<WongKeeTeaHouseSpecialBlend>().HasData(
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend001", Name = "鮮奶茶", Money1 = 40, Money2 = 50 },
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend002", Name = "綠奶茶", Money1 = 40, Money2 = 50 },
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend003", Name = "烏龍奶茶", Money1 = 40, Money2 = 50 },
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend004", Name = "吾優奶茶", Money1 = 40, Money2 = 50 },
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend005", Name = "豆漿紅茶", Money1 = 40, Money2 = 50 },
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend006", Name = "多多綠", Money1 = 40, Money2 = 50 },
                    new WongKeeTeaHouseSpecialBlend { ID = "WongKeeTeaHouseSpecialBlend007", Name = "多多紅", Money1 = 40, Money2 = 50 }
                );
                modelBuilder.Entity<WongKeeTeaHouseMat>().HasData(
                    new WongKeeTeaHouseMat { ID = "WongKeeTeaHouseMat001", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<WongKeeTeaHouseIce>().HasData(
                    new WongKeeTeaHouseIce { ID = "WongKeeTeaHouseIce001", IceName = "無法調整" }
                );
                modelBuilder.Entity<WongKeeTeaHouseSug>().HasData(
                    new WongKeeTeaHouseSug { ID = "WongKeeTeaHouseSug001", SugarName = "無法調整" }
                );
                //黛黛茶//
                modelBuilder.Entity<DedeTeaRoyalchoiceitem>().HasData(
                    new DedeTeaRoyalchoiceitem { ID = "DedeteaRoyalchoiceitem001", Name = "三皇黛黛茶", Money2 = 45 },
                    new DedeTeaRoyalchoiceitem { ID = "DedeteaRoyalchoiceitem002", Name = "凱薩琳皇后大吉嶺", Money1 = 30, Money2 = 35 },
                    new DedeTeaRoyalchoiceitem { ID = "DedeteaRoyalchoiceitem003", Name = "維多莉亞女王紅玉", Money1 = 35, Money2 = 40 },
                    new DedeTeaRoyalchoiceitem { ID = "DedeteaRoyalchoiceitem004", Name = "金萱綠茶", Money1 = 30, Money2 = 35 },
                    new DedeTeaRoyalchoiceitem { ID = "DedeteaRoyalchoiceitem005", Name = "四季青茶", Money1 = 30, Money2 = 35 },
                    new DedeTeaRoyalchoiceitem { ID = "DedeteaRoyalchoiceitem006", Name = "琥珀烏龍", Money1 = 35, Money2 = 40 }
                );
                modelBuilder.Entity<DedeTeaPrincessofFlowers>().HasData(
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers001", Name = "馥麗莓果大吉嶺", Money1 = 55, Money2 = 65 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers002", Name = "黃金香橙大吉嶺", Money1 = 50, Money2 = 60 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers003", Name = "黛黛紅玉果茶", Money1 = 55, Money2 = 65 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers004", Name = "凍檸茶", Money2 = 55 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers005", Name = "紅柚烏龍", Money2 = 60 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers006", Name = "甘蔗青茶", Money1 = 50, Money2 = 60 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers007", Name = "丹荔玫瑰公主", Money1 = 60, Money2 = 70 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers008", Name = "青檸青森蘋果飲", Money1 = 55, Money2 = 65 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers009", Name = "蜜桃紅玉", Money2 = 55 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers010", Name = "蜜桃青茶", Money2 = 55 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers011", Name = "蜜桃烏龍", Money2 = 55 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers012", Name = "咕溜蜜桃紅玉", Money2 = 65 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers013", Name = "咕溜蜜桃青茶", Money2 = 65 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers014", Name = "咕溜蜜桃烏龍", Money2 = 65 },
                    new DedeTeaPrincessofFlowers { ID = "DedeTeaPrincessofFlowers015", Name = "蜜桃沙沙", Money2 = 75 }
                );
                modelBuilder.Entity<DedeTeaRoyalLatte>().HasData(
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte001", Name = "焦糖布蕾王子", Money1 = 65 },
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte002", Name = "黑糖珍珠鮮奶", Money1 = 65, Money2 = 80 },
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte003", Name = "皇家拿鐵", Money1 = 55, Money2 = 65 },
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte004", Name = "烏龍拿鐵", Money1 = 55, Money2 = 65 },
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte005", Name = "凡爾賽玫瑰拿鐵", Money2 = 70 },
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte006", Name = "甘蔗拿鐵", Money2 = 75 },
                    new DedeTeaRoyalLatte { ID = "DedeTeaRoyalLatte007", Name = "皇家奶蓋茶", Money1 = 50, Money2 = 55 }
                );
                modelBuilder.Entity<DedeTeaRoyalFragrantMilkTea>().HasData(
                    new DedeTeaRoyalFragrantMilkTea { ID = "DedeTeaRoyalFragrantMilkTea001", Name = "三皇奶茶", Money2 = 55 },
                    new DedeTeaRoyalFragrantMilkTea { ID = "DedeTeaRoyalFragrantMilkTea002", Name = "皇家奶茶", Money1 = 45, Money2 = 55 },
                    new DedeTeaRoyalFragrantMilkTea { ID = "DedeTeaRoyalFragrantMilkTea003", Name = "皇家珍珠奶茶", Money1 = 50, Money2 = 60 },
                    new DedeTeaRoyalFragrantMilkTea { ID = "DedeTeaRoyalFragrantMilkTea004", Name = "烏龍奶茶", Money1 = 45, Money2 = 55 }
                );
                modelBuilder.Entity<DedeTeaClassicSpecialties>().HasData(
                    new DedeTeaClassicSpecialties { ID = "DedeTeaClassicSpecialties001", Name = "白露冬瓜", Money1 = 30, Money2 = 35 },
                    new DedeTeaClassicSpecialties { ID = "DedeTeaClassicSpecialties002", Name = "白露青檸", Money1 = 40, Money2 = 50 },
                    new DedeTeaClassicSpecialties { ID = "DedeTeaClassicSpecialties003", Name = "白露拿鐵", Money1 = 55, Money2 = 65 },
                    new DedeTeaClassicSpecialties { ID = "DedeTeaClassicSpecialties004", Name = "香濃可可'", Money1 = 60, Money2 = 65 },
                    new DedeTeaClassicSpecialties { ID = "DedeTeaClassicSpecialties005", Name = "可可布丁冰沙", Money2 = 75 }
                );
                modelBuilder.Entity<DedeTeaMat>().HasData(
                    new DedeTeaMat { ID = "DedeTeaMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new DedeTeaMat { ID = "DedeTeaMat002", TeaMaterialName = "椰果", Money = 10 },
                    new DedeTeaMat { ID = "DedeTeaMat003", TeaMaterialName = "奇亞籽", Money = 10 },
                    new DedeTeaMat { ID = "DedeTeaMat004", TeaMaterialName = "綠茶凍", Money = 10 },
                    new DedeTeaMat { ID = "DedeTeaMat005", TeaMaterialName = "玫瑰凍", Money = 10 },
                    new DedeTeaMat { ID = "DedeTeaMat006", TeaMaterialName = "黑糖珍珠", Money = 10 },
                    new DedeTeaMat { ID = "DedeTeaMat007", TeaMaterialName = "奶蓋", Money = 15 },
                    new DedeTeaMat { ID = "DedeTeaMat008", TeaMaterialName = "統一布丁", Money = 15 },
                    new DedeTeaMat { ID = "DedeTeaMat009", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<DedeTeaIce>().HasData(
                    new DedeTeaIce { ID = "DedeTeaIce001", IceName = "正常冰" },
                    new DedeTeaIce { ID = "DedeTeaIce002", IceName = "少冰" },
                    new DedeTeaIce { ID = "DedeTeaIce003", IceName = "微冰" },
                    new DedeTeaIce { ID = "DedeTeaIce004", IceName = "去冰" },
                    new DedeTeaIce { ID = "DedeTeaIce005", IceName = "完全去冰" },
                    new DedeTeaIce { ID = "DedeTeaIce006", IceName = "常溫" },
                    new DedeTeaIce { ID = "DedeTeaIce007", IceName = "熱" }
                );
                modelBuilder.Entity<DedeTeaSug>().HasData(
                    new DedeTeaSug { ID = "DedeTeaSug001", SugarName = "全糖" },
                    new DedeTeaSug { ID = "DedeTeaSug002", SugarName = "少糖" },
                    new DedeTeaSug { ID = "DedeTeaSug003", SugarName = "半糖" },
                    new DedeTeaSug { ID = "DedeTeaSug004", SugarName = "微糖" },
                    new DedeTeaSug { ID = "DedeTeaSug005", SugarName = "一分糖" },
                    new DedeTeaSug { ID = "DedeTeaSug006", SugarName = "無糖" }
                );
                //茶聚//
                modelBuilder.Entity<CHAGESpecialBlend>().HasData(
                    new CHAGESpecialBlend { ID = "CHAGESpecialBlend001", Name = "冬瓜玉露",Money1 = 30, Money2 = 35 },
                    new CHAGESpecialBlend { ID = "CHAGESpecialBlend002", Name = "鮮檸檬冬瓜(限冷飲)", Money1 = 35, Money2 = 45 },
                    new CHAGESpecialBlend { ID = "CHAGESpecialBlend003", Name = "沐嵐平安紅", Money1 = 50, Money2 = 55 },
                    new CHAGESpecialBlend { ID = "CHAGESpecialBlend004", Name = "鮮寧不知青(限冷飲)", Money1 = 50, Money2 = 55 },
                    new CHAGESpecialBlend { ID = "CHAGESpecialBlend005", Name = "戀寧不知青(限冷飲)", Money2 = 55 },
                    new CHAGESpecialBlend { ID = "CHAGESpecialBlend006", Name = "鮮寧蜜蘆薈(限冷飲)", Money2 = 30 }
                );
                modelBuilder.Entity<CHAGEMilk>().HasData(
                    new CHAGEMilk { ID = "CHAGEMilk001", Name = "沐蘭鮮奶紅", Money1 = 50, Money2 = 60 },
                    new CHAGEMilk { ID = "CHAGEMilk002", Name = "迎曦鮮奶烏", Money1 = 55, Money2 = 65 },
                    new CHAGEMilk { ID = "CHAGEMilk003", Name = "半熟招牌鮮", Money1 = 60, Money2 = 70 },
                    new CHAGEMilk { ID = "CHAGEMilk004", Name = "黑糖珍珠鮮奶", Money1 = 60, Money2 = 70 },
                    new CHAGEMilk { ID = "CHAGEMilk005", Name = "靜岡抹茶鮮", Money1 = 60, Money2 = 70 }
                    
                );
                modelBuilder.Entity<CHAGETea>().HasData(
                    new CHAGETea { ID = "CHAGETea001", Name = "0816李果紅", Money2 = 35 },
                    new CHAGETea { ID = "CHAGETea002", Name = "石泉烏青", Money2 = 35 },
                    new CHAGETea { ID = "CHAGETea003", Name = "迎曦烏龍", Money2 = 35 },
                    new CHAGETea { ID = "CHAGETea004", Name = "不知青", Money2 = 35 },
                    new CHAGETea { ID = "CHAGETea005", Name = "鳴翠金萱", Money2 = 35 },
                    new CHAGETea { ID = "CHAGETea006", Name = "黃金芯芽(限黑糖)", Money2 = 45 },
                    new CHAGETea { ID = "CHAGETea007", Name = "蕎寶茶(限黑糖)", Money2 = 45 }
                );
                modelBuilder.Entity<CHAGEScentedTea>().HasData(
                    new CHAGEScentedTea { ID = "CHAGEScentedTea001", Name = "香片姍姍", Money2 = 35 },
                    new CHAGEScentedTea { ID = "CHAGEScentedTea002", Name = "姍姍凍檸(限冷飲)", Money2 = 55 },
                    new CHAGEScentedTea { ID = "CHAGEScentedTea003", Name = "姍姍奶綠", Money1 = 45, Money2 = 55 },
                    new CHAGEScentedTea { ID = "CHAGEScentedTea004", Name = "姍姍葡柚綠 (限冷飲)", Money1 = 55, Money2 = 60 }
                );
                modelBuilder.Entity<CHAGEMilkTea>().HasData(
                    new CHAGEMilkTea { ID = "CHAGEMilkTea001", Name = "沐嵐奶茶", Money1 = 45, Money2 = 50 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea002", Name = "沐嵐珍奶", Money1 = 45, Money2 = 50 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea003", Name = "迎曦烏龍奶", Money1 = 45, Money2 = 55 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea004", Name = "巧克力可可'", Money1 = 45, Money2 = 55 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea005", Name = "咖啡寒天奶茶", Money1 = 50, Money2 = 60 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea006", Name = "沐嵐熊貓奶", Money2 = 60 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea007", Name = "沐嵐黃晶熊貓奶'", Money2 = 60 },
                    new CHAGEMilkTea { ID = "CHAGEMilkTea008", Name = "半熟奶茶", Money2 = 60 }
                );
                modelBuilder.Entity<CHAGETeaGoodMat>().HasData(
                    new CHAGETeaGoodMat { ID = "CHAGETeaGoodMat001", Name = "珍椰金萱", Money2 = 55 },
                    new CHAGETeaGoodMat { ID = "CHAGETeaGoodMat002", Name = "珍芋冬瓜", Money2 = 60 },
                    new CHAGETeaGoodMat { ID = "CHAGETeaGoodMat003", Name = "寒芋姍姍", Money2 = 65 },
                    new CHAGETeaGoodMat { ID = "CHAGETeaGoodMat004", Name = "綠豆芋奶茶", Money2 = 70 },
                    new CHAGETeaGoodMat { ID = "CHAGETeaGoodMat005", Name = "蘋果寒天凍", Money2 = 75 },
                    new CHAGETeaGoodMat { ID = "CHAGETeaGoodMat006", Name = "膠原貴妃(限冷飲)", Money2 = 75 }
                );
                modelBuilder.Entity<CHAGESeasonal>().HasData(
                    new CHAGESeasonal { ID = "CHAGESeasonal001", Name = "綠豆冰沙(甜度固定)(限冷飲)", Money2 = 50 },
                    new CHAGESeasonal { ID = "CHAGESeasonal002", Name = "綠豆牛奶冰沙(甜度固定)(限冷飲)", Money2 = 60 },
                    new CHAGESeasonal { ID = "CHAGESeasonal003", Name = "巧脆冰沙 (甜度固定)(限冷飲)", Money1 = 65 }
                );
                modelBuilder.Entity<CHAGENaigai>().HasData(
                    new CHAGENaigai { ID = "CHAGENaigai001", Name = "沐雲金萱", Money2 = 55 },
                    new CHAGENaigai { ID = "CHAGENaigai002", Name = "沐雲紅", Money2 = 55 },
                    new CHAGENaigai { ID = "CHAGENaigai003", Name = "沐雲可可 (甜度固定)", Money2 = 65 },
                    new CHAGENaigai { ID = "CHAGENaigai004", Name = "沐雲蕎寶(限黑糖)", Money2 = 65 }
                );
                modelBuilder.Entity<CHAGEMat>().HasData(
                    new CHAGEMat { ID = "CHAGEMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new CHAGEMat { ID = "CHAGEMat002", TeaMaterialName = "椰果", Money = 10 },
                    new CHAGEMat { ID = "CHAGEMat003", TeaMaterialName = "黑糖珍珠", Money = 10 },
                    new CHAGEMat { ID = "CHAGEMat004", TeaMaterialName = "蘆薈", Money = 10 },
                    new CHAGEMat { ID = "CHAGEMat005", TeaMaterialName = "茶凍", Money = 10 },
                    new CHAGEMat { ID = "CHAGEMat006", TeaMaterialName = "綠豆", Money = 10 },
                    new CHAGEMat { ID = "CHAGEMat007", TeaMaterialName = "寒天", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat008", TeaMaterialName = "黃晶", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat009", TeaMaterialName = "熊貓", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat010", TeaMaterialName = "黃晶熊貓", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat011", TeaMaterialName = "小芋園", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat012", TeaMaterialName = "咖啡寒天", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat013", TeaMaterialName = "膠原凍", Money = 15 },
                    new CHAGEMat { ID = "CHAGEMat014", TeaMaterialName = "奶蓋", Money = 20 },
                    new CHAGEMat { ID = "CHAGEMat015", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<CHAGEIce>().HasData(
                    new CHAGEIce { ID = "CHAGEIce001", IceName = "正常冰" },
                    new CHAGEIce { ID = "CHAGEIce002", IceName = "少冰" },
                    new CHAGEIce { ID = "CHAGEIce003", IceName = "微冰" },
                    new CHAGEIce { ID = "CHAGEIce004", IceName = "去冰" },
                    new CHAGEIce { ID = "CHAGEIce005", IceName = "常溫" },
                    new CHAGEIce { ID = "CHAGEIce006", IceName = "熱" }
                );
                modelBuilder.Entity<CHAGESug>().HasData(
                    new CHAGESug { ID = "CHAGESug001", SugarName = "正常糖" },
                    new CHAGESug { ID = "CHAGESug002", SugarName = "少糖" },
                    new CHAGESug { ID = "CHAGESug003", SugarName = "半糖" },
                    new CHAGESug { ID = "CHAGESug004", SugarName = "微糖" },
                    new CHAGESug { ID = "CHAGESug005", SugarName = "無糖" }
                );
                //大茗玉露青茶專賣店//
                modelBuilder.Entity<DaMingJadeDewClassic>().HasData(
                    new DaMingJadeDewClassic { ID = "DaMingJadeDewClassic001", Name = "冬瓜玉露青", Money2 = 30 },
                    new DaMingJadeDewClassic { ID = "DaMingJadeDewClassic002", Name = "蘋果玉露青",Money2 = 60 },
                    new DaMingJadeDewClassic { ID = "DaMingJadeDewClassic003", Name = "甘蔗玉露青", Money2 = 60 },
                    new DaMingJadeDewClassic { ID = "DaMingJadeDewClassic004", Name = "鮮檸玉露青", Money2 = 60 },
                    new DaMingJadeDewClassic { ID = "DaMingJadeDewClassic005", Name = "鳳梨玉露青", Money2 = 60 }
                );
                modelBuilder.Entity<DaMingJadeDewOriginalTea>().HasData(
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea001", Name = "玉露青茶", Money2 = 30 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea002", Name = "紅玉紅茶", Money2 = 30 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea003", Name = "四薰綠茶", Money2 = 30 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea004", Name = "覆焙鐵觀音", Money2 = 30 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea005", Name = "御品冬瓜綠", Money2 = 30 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea006", Name = "翡翠青茶", Money2 = 40 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea007", Name = "桂花青茶", Money2 = 40 },
                    new DaMingJadeDewOriginalTea { ID = "DaMingJadeDewOriginalTea008", Name = "冰釀烏龍", Money2 = 50 }

                );
                modelBuilder.Entity<DaMingJadeDewLatte>().HasData(
                    new DaMingJadeDewLatte { ID = "DaMingJadeDewLatte001", Name = "黑糖珍珠", Money1 = 50 },
                    new DaMingJadeDewLatte { ID = "DaMingJadeDewLatte002", Name = "玉露拿鐵", Money2 = 60 },
                    new DaMingJadeDewLatte { ID = "DaMingJadeDewLatte003", Name = "紅茶拿鐵", Money2 = 60 },
                    new DaMingJadeDewLatte { ID = "DaMingJadeDewLatte004", Name = "鐵觀音拿鐵", Money2 = 60 },
                    new DaMingJadeDewLatte { ID = "DaMingJadeDewLatte005", Name = "鮮草嫩奶", Money2 = 60 }
                );
                modelBuilder.Entity<DaMingJadeDewMilkTea>().HasData(
                    new DaMingJadeDewMilkTea { ID = "DaMingJadeDewMilkTea001", Name = "嚴選厚奶茶", Money2 = 50 },
                    new DaMingJadeDewMilkTea { ID = "DaMingJadeDewMilkTea002", Name = "嚴選厚綠茶", Money2 = 50 },
                    new DaMingJadeDewMilkTea { ID = "DaMingJadeDewMilkTea003", Name = "嚴選厚鐵觀音", Money2 = 50 },
                    new DaMingJadeDewMilkTea { ID = "DaMingJadeDewMilkTea004", Name = "咖啡凍鐵觀音厚奶茶", Money2 = 50 },
                    new DaMingJadeDewMilkTea { ID = "DaMingJadeDewMilkTea005", Name = "波霸厚奶茶", Money2 = 55 }
                );
                modelBuilder.Entity<DaMingJadeDewNaigai>().HasData(
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai001", Name = "酪梨奶茶", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai002", Name = "酪梨紅茶", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai003", Name = "酪梨鐵觀音", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai004", Name = "酪梨綠茶'", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai005", Name = "酪梨冬瓜茶", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai006", Name = "酪梨青茶", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai007", Name = "酪梨冬瓜青'", Money2 = 55 },
                    new DaMingJadeDewNaigai { ID = "DaMingJadeDewNaigai008", Name = "酪梨奶蓋草莓青", Money2 = 90 }
                );
                modelBuilder.Entity<DaMingJadeDewWinterOnly>().HasData(
                    new DaMingJadeDewWinterOnly { ID = "DaMingJadeDewWinterOnly001", Name = "暖薑原萃", Money1 = 40 },
                    new DaMingJadeDewWinterOnly { ID = "DaMingJadeDewWinterOnly002", Name = "暖薑紅玉", Money1 = 45 },
                    new DaMingJadeDewWinterOnly { ID = "DaMingJadeDewWinterOnly003", Name = "暖薑厚奶茶", Money1 = 45 },
                    new DaMingJadeDewWinterOnly { ID = "DaMingJadeDewWinterOnly004", Name = "蔗香暖薑", Money1 = 60 }
                );
                modelBuilder.Entity<DaMingJadeDewFreshFruit>().HasData(
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit001", Name = "鮮檸冬瓜露", Money2 = 45 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit002", Name = "鮮檸翡翠青茶", Money2 = 50 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit003", Name = "鮮檸翡翠紅茶", Money2 = 50 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit004", Name = "翡翠百香青'", Money2 = 55 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit005", Name = "翡翠多多青'", Money2 = 55 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit006", Name = "紫蝶蜜檸凍(蝶豆花+檸檬汁+蜂蜜+蘆薈)", Money2 = 60 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit007", Name = "甘蔗檸檬", Money2 = 60 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit008", Name = "葡萄柚桂花青", Money2 = 65 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit009", Name = "奇異果翡翠青", Money2 = 70 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit010", Name = "藍莓翡翠青'", Money2 = 75 },
                    new DaMingJadeDewFreshFruit { ID = "DaMingJadeDewFreshFruit011", Name = "草莓翡翠青", Money2 = 80 }
                );
                modelBuilder.Entity<DaMingJadeDewMat>().HasData(
                    new DaMingJadeDewMat { ID = "CHAGEMat001", TeaMaterialName = "珍珠", Money = 5 },
                    new DaMingJadeDewMat { ID = "CHAGEMat003", TeaMaterialName = "黑糖珍珠", Money = 10 },
                    new DaMingJadeDewMat { ID = "CHAGEMat004", TeaMaterialName = "咖啡凍", Money = 10 },
                    new DaMingJadeDewMat { ID = "CHAGEMat005", TeaMaterialName = "蘆薈", Money = 10 },
                    new DaMingJadeDewMat { ID = "CHAGEMat006", TeaMaterialName = "仙草", Money = 10 },
                    new DaMingJadeDewMat { ID = "CHAGEMat007", TeaMaterialName = "酪梨奶蓋", Money = 15 },
                    new DaMingJadeDewMat { ID = "CHAGEMat008", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<DaMingJadeDewIce>().HasData(
                    new DaMingJadeDewIce { ID = "CHAGEIce001", IceName = "正常" },
                    new DaMingJadeDewIce { ID = "CHAGEIce002", IceName = "少冰" },
                    new DaMingJadeDewIce { ID = "CHAGEIce003", IceName = "微冰" },
                    new DaMingJadeDewIce { ID = "CHAGEIce004", IceName = "去冰" }
                );
                modelBuilder.Entity<DaMingJadeDewSug>().HasData(
                    new DaMingJadeDewSug { ID = "CHAGESug001", SugarName = "正常(100%)" },
                    new DaMingJadeDewSug { ID = "CHAGESug002", SugarName = "少糖(70%)" },
                    new DaMingJadeDewSug { ID = "CHAGESug003", SugarName = "半糖(50%)" },
                    new DaMingJadeDewSug { ID = "CHAGESug004", SugarName = "微糖(30%)" },
                    new DaMingJadeDewSug { ID = "CHAGESug005", SugarName = "一分糖(1%)" },
                    new DaMingJadeDewSug { ID = "CHAGESug006", SugarName = "無糖(0%)" }
                );
                //上宇林//
                modelBuilder.Entity<ShangYulinTop>().HasData(
                    new ShangYulinTop { ID = "ShangYulinTop001", Name = "上宇林青茶", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop002", Name = "上宇林紅茶", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop003", Name = "三窨花綠茶", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop004", Name = "蟲蝕烏龍茶", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop005", Name = "東方美人", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop006", Name = "紅龍茗茶", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop007", Name = "綠龍茗茶", Money = 35 },
                    new ShangYulinTop { ID = "ShangYulinTop008", Name = "青龍茗茶", Money = 35 }
                );
                modelBuilder.Entity<ShangYulinRich>().HasData(
                    new ShangYulinRich { ID = "ShangYulinRich001", Name = "雪浮奶紅茶", Money = 60 },
                    new ShangYulinRich { ID = "ShangYulinRich002", Name = "雪浮奶綠茶", Money = 60 },
                    new ShangYulinRich { ID = "ShangYulinRich003", Name = "雪浮奶青茶", Money = 60 },
                    new ShangYulinRich { ID = "ShangYulinRich004", Name = "雪浮奶烏龍茶", Money = 60 },
                    new ShangYulinRich { ID = "ShangYulinRich005", Name = "雪浮奶美人", Money = 60 }

                );
                modelBuilder.Entity<ShangYulinMilk>().HasData(
                    new ShangYulinMilk { ID = "ShangYulinMilk001", Name = "鼎極鮮奶茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk002", Name = "太極鮮奶茶", Money = 70 },
                    new ShangYulinMilk { ID = "ShangYulinMilk003", Name = "紅龍鮮奶茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk004", Name = "鐵觀音鮮奶茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk005", Name = "鮮奶綠茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk006", Name = "鮮奶青茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk007", Name = "烏龍鮮奶茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk008", Name = "美人鮮奶茶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk009", Name = "冬瓜鮮奶", Money = 60 },
                    new ShangYulinMilk { ID = "ShangYulinMilk010", Name = "冬瓜鮮奶茶", Money = 70 },
                    new ShangYulinMilk { ID = "ShangYulinMilk011", Name = "冰淇淋鮮奶茶", Money = 80 },
                    new ShangYulinMilk { ID = "ShangYulinMilk012", Name = "手工粉角鮮奶茶", Money = 70 },
                    new ShangYulinMilk { ID = "ShangYulinMilk013", Name = "仙草凍鮮奶茶", Money = 70 },
                    new ShangYulinMilk { ID = "ShangYulinMilk014", Name = "椰果鮮奶茶", Money = 70 },
                    new ShangYulinMilk { ID = "ShangYulinMilk015", Name = "布丁鮮奶茶", Money = 75 },
                    new ShangYulinMilk { ID = "ShangYulinMilk016", Name = "珍珠鮮奶茶", Money = 70 }
                );
                modelBuilder.Entity<ShangYulinTea>().HasData(
                    new ShangYulinTea { ID = "ShangYulinTea001", Name = "布丁冬瓜茶", Money = 50 },
                    new ShangYulinTea { ID = "ShangYulinTea002", Name = "布丁紅茶", Money = 50 },
                    new ShangYulinTea { ID = "ShangYulinTea003", Name = "布丁綠茶", Money = 50 },
                    new ShangYulinTea { ID = "ShangYulinTea004", Name = "布丁青茶", Money = 50 },
                    new ShangYulinTea { ID = "ShangYulinTea005", Name = "布丁烏龍茶", Money = 50 },
                    new ShangYulinTea { ID = "ShangYulinTea006", Name = "脆梅綠茶", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea007", Name = "冬瓜茶", Money = 35 },
                    new ShangYulinTea { ID = "ShangYulinTea008", Name = "冬瓜青茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea009", Name = "冬瓜綠茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea010", Name = "黃金多多綠", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea011", Name = "檸檬紅茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea012", Name = "檸檬青茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea013", Name = "檸檬綠茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea014", Name = "檸檬冬瓜茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea015", Name = "香橙青茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea016", Name = "香橙綠茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea017", Name = "葡萄柚青茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea018", Name = "葡萄柚綠茶", Money = 60 },
                    new ShangYulinTea { ID = "ShangYulinTea019", Name = "冰淇淋紅茶", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea020", Name = "冰淇淋青茶", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea021", Name = "冰淇淋綠茶", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea022", Name = "冰淇淋烏龍茶", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea023", Name = "冰淇淋冬瓜茶", Money = 55 },
                    new ShangYulinTea { ID = "ShangYulinTea024", Name = "仙草凍紅茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea025", Name = "仙草凍青茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea026", Name = "仙草凍綠茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea027", Name = "仙草凍烏龍茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea028", Name = "仙草凍冬瓜茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea029", Name = "太極紅茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea030", Name = "太極青茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea031", Name = "太極綠茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea032", Name = "太極烏龍茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea033", Name = "太極冬瓜茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea034", Name = "椰果紅茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea035", Name = "椰果青茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea036", Name = "椰果綠茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea037", Name = "椰果烏龍茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea038", Name = "椰果冬瓜茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea039", Name = "珍珠紅茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea040", Name = "珍珠青茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea041", Name = "珍珠綠茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea042", Name = "珍珠烏龍茶", Money = 45 },
                    new ShangYulinTea { ID = "ShangYulinTea043", Name = "珍珠冬瓜茶", Money = 45 }

                );
                modelBuilder.Entity<ShangYulinHealth>().HasData(
                    new ShangYulinHealth { ID = "ShangYulinHealth001", Name = "桂圓紅棗茶", Money = 55 },
                    new ShangYulinHealth { ID = "ShangYulinHealth002", Name = "桂圓紅棗鮮奶茶", Money = 75 },
                    new ShangYulinHealth { ID = "ShangYulinHealth003", Name = "薑軍茶", Money = 55 },
                    new ShangYulinHealth { ID = "ShangYulinHealth004", Name = "薑軍鮮奶茶'", Money = 75 }
                );
                modelBuilder.Entity<ShangYulinMountain>().HasData(
                    new ShangYulinMountain { ID = "ShangYulinMountain001", Name = "精鐉雨林", Money = 60 }
                );
                modelBuilder.Entity<ShangYulinMat>().HasData(
                    new ShangYulinMat { ID = "ShangYulinMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new ShangYulinMat { ID = "ShangYulinMat002", TeaMaterialName = "椰果", Money = 10 },
                    new ShangYulinMat { ID = "ShangYulinMat003", TeaMaterialName = "仙草凍", Money = 10 },
                    new ShangYulinMat { ID = "ShangYulinMat004", TeaMaterialName = "手工粉角", Money = 10 },
                    new ShangYulinMat { ID = "ShangYulinMat005", TeaMaterialName = "QQ", Money = 10 },
                    new ShangYulinMat { ID = "ShangYulinMat006", TeaMaterialName = "太極", Money = 10 },
                    new ShangYulinMat { ID = "ShangYulinMat007", TeaMaterialName = "多多", Money = 20 },
                    new ShangYulinMat { ID = "ShangYulinMat008", TeaMaterialName = "香草冰淇淋", Money = 20 },
                    new ShangYulinMat { ID = "ShangYulinMat009", TeaMaterialName = "話梅", Money = 15 },
                    new ShangYulinMat { ID = "ShangYulinMat010", TeaMaterialName = "布丁", Money = 15 },
                    new ShangYulinMat { ID = "ShangYulinMat011", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<ShangYulinIce>().HasData(
                    new ShangYulinIce { ID = "ShangYulinIce001", IceName = "正常冰" },
                    new ShangYulinIce { ID = "ShangYulinIce002", IceName = "少冰" },
                    new ShangYulinIce { ID = "ShangYulinIce003", IceName = "微冰" },
                    new ShangYulinIce { ID = "ShangYulinIce004", IceName = "去冰" }
                );
                modelBuilder.Entity<ShangYulinSug>().HasData(
                    new ShangYulinSug { ID = "ShangYulinSug001", SugarName = "正常糖" },
                    new ShangYulinSug { ID = "ShangYulinSug002", SugarName = "少糖" },
                    new ShangYulinSug { ID = "ShangYulinSug003", SugarName = "半糖" },
                    new ShangYulinSug { ID = "ShangYulinSug004", SugarName = "微糖" },
                    new ShangYulinSug { ID = "ShangYulinSug005", SugarName = "無糖" }
                );
                //萬波//
                modelBuilder.Entity<WanboFeatured>().HasData(
                    new WanboFeatured { ID = "WanboFeatured001", Name = "島嶼紅茶", Money1 = 30, Money2 = 35 },
                    new WanboFeatured { ID = "WanboFeatured002", Name = "普通紅茶", Money1 = 30, Money2 = 35 },
                    new WanboFeatured { ID = "WanboFeatured003", Name = "宣橋綠茶", Money1 = 30, Money2 = 35 },
                    new WanboFeatured { ID = "WanboFeatured004", Name = "麗雅烏龍", Money1 = 30, Money2 = 35 },
                    new WanboFeatured { ID = "WanboFeatured005", Name = "金萱青茶", Money1 = 30, Money2 = 35 },
                    new WanboFeatured { ID = "WanboFeatured006", Name = "烏龍鐵觀音", Money1 = 30, Money2 = 35 }
                );
                modelBuilder.Entity<WanboHandPath>().HasData(
                    new WanboHandPath { ID = "WanboHandPath001", Name = "蜂蜜金萱", Money1 = 45, Money2 = 50 },
                    new WanboHandPath { ID = "WanboHandPath002", Name = "蜂蜜麗雅", Money1 = 45, Money2 = 50 },
                    new WanboHandPath { ID = "WanboHandPath003", Name = "金萱珍波粉", Money1 = 45, Money2 = 50 },
                    new WanboHandPath { ID = "WanboHandPath004", Name = "金牌愛玉檸檬(茶)", Money1 = 50, Money2 = 60 },
                    new WanboHandPath { ID = "WanboHandPath005", Name = "杏花雨露(糖固)(茶)", Money1 = 45, Money2 = 55 }
                );
                modelBuilder.Entity<WanboMilk>().HasData(
                    new WanboMilk { ID = "WanboMilk001", Name = "萬波奶茶", Money1 = 40, Money2 = 50 },
                    new WanboMilk { ID = "WanboMilk002", Name = "普通奶茶", Money1 = 40, Money2 = 50 },
                    new WanboMilk { ID = "WanboMilk003", Name = "芋園茉香奶綠", Money1 = 50, Money2 = 60 },
                    new WanboMilk { ID = "WanboMilk004", Name = "鐵觀音奶茶", Money1 = 40, Money2 = 50 },
                    new WanboMilk { ID = "WanboMilk005", Name = "波霸奶茶", Money1 = 50, Money2 = 60 },
                    new WanboMilk { ID = "WanboMilk006", Name = "宣橋奶綠", Money1 = 40, Money2 = 50 }
                );
                modelBuilder.Entity<WanboOld>().HasData(
                    new WanboOld { ID = "WanboOld001", Name = "永良冬瓜露 (糖固)", Money1 = 30, Money2 = 40 },
                    new WanboOld { ID = "WanboOld002", Name = "冬瓜金萱青", Money1 = 35, Money2 = 45 },
                    new WanboOld { ID = "WanboOld003", Name = "冬瓜鮮奶", Money1 = 50, Money2 = 60 },
                    new WanboOld { ID = "WanboOld004", Name = "冬瓜檸檬", Money1 = 40, Money2 = 50 }
                );
                modelBuilder.Entity<WanboMilKTea>().HasData(
                    new WanboMilKTea { ID = "WanboMilKTea001", Name = "蘭葉那堤", Money1 = 55, Money2 = 65 },
                    new WanboMilKTea { ID = "WanboMilKTea002", Name = "鐵觀音那堤", Money1 = 50, Money2 = 60 },
                    new WanboMilKTea { ID = "WanboMilKTea003", Name = "茉莉那堤", Money1 = 50, Money2 = 60 },
                    new WanboMilKTea { ID = "WanboMilKTea004", Name = "黑糖珍珠鮮奶 (冰固)", Money1 = 65 },
                    new WanboMilKTea { ID = "WanboMilKTea005", Name = "紅豆粉粿鮮奶 (冰固)", Money1 = 65 },
                    new WanboMilKTea { ID = "WanboMilKTea006", Name = "燕麥蘭葉那堤", Money1 = 70, Money2 = 80 }
                );
                modelBuilder.Entity<WanboFruit>().HasData(
                    new WanboFruit { ID = "WanboFruit001", Name = "島嶼檸檬茶王", Money1 = 50, Money2 = 60 },
                    new WanboFruit { ID = "WanboFruit002", Name = "白柚烏龍", Money1 = 65, Money2 = 75 },
                    new WanboFruit { ID = "WanboFruit003", Name = "白柚翡翠", Money1 = 65, Money2 = 75 },
                    new WanboFruit { ID = "WanboFruit004", Name = "白柚金萱", Money1 = 65, Money2 = 75 },
                    new WanboFruit { ID = "WanboFruit005", Name = "紅蘋島嶼", Money1 = 50, Money2 = 60 },
                    new WanboFruit { ID = "WanboFruit006", Name = "埔里甘蔗青", Money1 = 50, Money2 = 60 },
                    new WanboFruit { ID = "WanboFruit007", Name = "翠涎香檸綠", Money1 = 50, Money2 = 60 },
                    new WanboFruit { ID = "WanboFruit008", Name = "大青梅果綠", Money1 = 50, Money2 = 60 },
                    new WanboFruit { ID = "WanboFruit009", Name = "蔗香煙燻烏梅(茶)", Money1 = 50, Money2 = 60 },
                    new WanboFruit { ID = "WanboFruit010", Name = "甘蔗檸檬", Money1 = 55, Money2 = 65 }
                );
                modelBuilder.Entity<WanboWinter>().HasData(
                    new WanboWinter { ID = "WanboWinter001", Name = "芋頭鮮奶 (冰固)", Money1 = 70, Money2 = 80 },
                    new WanboWinter { ID = "WanboWinter002", Name = "芋頭波霸鮮奶 (冰固)", Money1 = 75, Money2 = 85 },
                    new WanboWinter { ID = "WanboWinter003", Name = "芋芋三混圓 (冰固)", Money1 = 75, Money2 = 85 },
                    new WanboWinter { ID = "WanboWinter004", Name = "春橙翡翠", Money1 = 65, Money2 = 75 },
                    new WanboWinter { ID = "WanboWinter005", Name = "春橙烏龍", Money1 = 65, Money2 = 75 },
                    new WanboWinter { ID = "WanboWinter006", Name = "春橙愛玉 (茶)", Money1 = 65, Money2 = 75 },
                    new WanboWinter { ID = "WanboWinter007", Name = "黑糖薑茶", Money2 = 45 },
                    new WanboWinter { ID = "WanboWinter008", Name = "薑汁紅茶", Money2 = 50 },
                    new WanboWinter { ID = "WanboWinter009", Name = "薑汁撞奶", Money2 = 50 },
                    new WanboWinter { ID = "WanboWinter010", Name = "薑汁紅白小湯圓 (冬至上市)", Money2 = 60 }
                );
                modelBuilder.Entity<WanboMat>().HasData(
                    new WanboMat { ID = "WanboMat001", TeaMaterialName = "愛玉", Money = 10 },
                    new WanboMat { ID = "WanboMat002", TeaMaterialName = "芋園", Money = 10 },
                    new WanboMat { ID = "WanboMat003", TeaMaterialName = "波霸", Money = 10 },
                    new WanboMat { ID = "WanboMat004", TeaMaterialName = "小珍珠", Money = 10 },
                    new WanboMat { ID = "WanboMat005", TeaMaterialName = "杏仁凍", Money = 10 },
                    new WanboMat { ID = "WanboMat006", TeaMaterialName = "粉粿", Money = 15 },
                    new WanboMat { ID = "WanboMat007", TeaMaterialName = "珍波粉", Money = 15 },
                    new WanboMat { ID = "WanboMat008", TeaMaterialName = "紅白小湯圓", Money = 15 },
                    new WanboMat { ID = "WanboMat009", TeaMaterialName = "換購燕麥奶", Money = 15 },
                    new WanboMat { ID = "WanboMat010", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<WanboIce>().HasData(
                    new WanboIce { ID = "WanboIce001", IceName = "正常冰" },
                    new WanboIce { ID = "WanboIce002", IceName = "少冰" },
                    new WanboIce { ID = "WanboIce003", IceName = "微冰" },
                    new WanboIce { ID = "WanboIce004", IceName = "去冰" },
                    new WanboIce { ID = "WanboIce005", IceName = "溫熱" }
                );
                modelBuilder.Entity<WanboSug>().HasData(
                    new WanboSug { ID = "WanboSug001", SugarName = "正常糖" },
                    new WanboSug { ID = "WanboSug002", SugarName = "少糖" },
                    new WanboSug { ID = "WanboSug003", SugarName = "半糖" },
                    new WanboSug { ID = "WanboSug004", SugarName = "微糖" },
                    new WanboSug { ID = "WanboSug005", SugarName = "微微糖" },
                    new WanboSug { ID = "WanboSug006", SugarName = "無糖" }
                );
                //皇后先生//
                modelBuilder.Entity<MrQueenTea>().HasData(
                    new MrQueenTea { ID = "MrQueenTea001", Name = "國王紅茶", Money1 = 30, Money2 = 35 },
                    new MrQueenTea { ID = "MrQueenTea002", Name = "國王綠茶", Money1 = 30, Money2 = 35 },
                    new MrQueenTea { ID = "MrQueenTea003", Name = "岩山青茶", Money1 = 30, Money2 = 35 },
                    new MrQueenTea { ID = "MrQueenTea004", Name = "焙香烏龍綠", Money1 = 30, Money2 = 35 }
                );
                modelBuilder.Entity<MrQueenMilk>().HasData(
                    new MrQueenMilk { ID = "MrQueenMilk001", Name = "國王奶茶", Money1 = 40, Money2 = 50 },
                    new MrQueenMilk { ID = "MrQueenMilk002", Name = "國王奶綠", Money1 = 40, Money2 = 50 },
                    new MrQueenMilk { ID = "MrQueenMilk003", Name = "國王烏龍奶綠", Money1 = 40, Money2 = 50 },
                    new MrQueenMilk { ID = "MrQueenMilk004", Name = "國王奶青", Money1 = 40, Money2 = 50 },
                    new MrQueenMilk { ID = "MrQueenMilk005", Name = "濃情巧克力奶", Money1 = 40, Money2 = 50 },
                    new MrQueenMilk { ID = "MrQueenMilk006", Name = "國王燕麥奶", Money1 = 40, Money2 = 50 }
                );
                modelBuilder.Entity<MrQueenCoffee>().HasData(
                    new MrQueenCoffee { ID = "MrQueenCoffee001", Name = "美式咖啡", Money1 = 35, Money2 = 45 },
                    new MrQueenCoffee { ID = "MrQueenCoffee002", Name = "雲朵拿鐵咖啡", Money1 = 50, Money2 = 60 },
                    new MrQueenCoffee { ID = "MrQueenCoffee003", Name = "雲朵香草拿鐵", Money1 = 55, Money2 = 65 },
                    new MrQueenCoffee { ID = "MrQueenCoffee004", Name = "雲朵榛果拿鐵", Money1 = 55, Money2 = 65 },
                    new MrQueenCoffee { ID = "MrQueenCoffee005", Name = "雲朵焦糖拿鐵", Money1 = 55, Money2 = 65 }
                );
                modelBuilder.Entity<MrQueenTallMilk>().HasData(
                    new MrQueenTallMilk { ID = "MrQueenTallMilk001", Name = "紅茶拿鐵", Money1 = 55, Money2 = 65 },
                    new MrQueenTallMilk { ID = "MrQueenTallMilk002", Name = "綠茶拿鐵", Money1 = 55, Money2 = 65 },
                    new MrQueenTallMilk { ID = "MrQueenTallMilk003", Name = "烏龍綠拿鐵", Money1 = 55, Money2 = 65 },
                    new MrQueenTallMilk { ID = "MrQueenTallMilk004", Name = "岩山青拿鐵", Money1 = 55, Money2 = 65 },
                    new MrQueenTallMilk { ID = "MrQueenTallMilk005", Name = "濃情巧克力歐蕾", Money1 = 55, Money2 = 65 }
                );
                modelBuilder.Entity<MrQueenFive>().HasData(
                    new MrQueenFive { ID = "MrQueenFive001", Name = "珍珠奶茶", Money1 = 40, Money2 = 50 },
                    new MrQueenFive { ID = "MrQueenFive002", Name = "布丁奶茶", Money1 = 45, Money2 = 55 },
                    new MrQueenFive { ID = "MrQueenFive003", Name = "國王奶綠", Money1 = 40, Money2 = 50 },
                    new MrQueenFive { ID = "MrQueenFive004", Name = "養樂多綠茶", Money1 = 40, Money2 = 50 },
                    new MrQueenFive { ID = "MrQueenFive005", Name = "話梅綠茶", Money1 = 35, Money2 = 40 }
                );
                modelBuilder.Entity<MrQueenMat>().HasData(
                    new MrQueenMat { ID = "MrQueenMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new MrQueenMat { ID = "MrQueenMat002", TeaMaterialName = "椰果", Money = 10 },
                    new MrQueenMat { ID = "MrQueenMat003", TeaMaterialName = "燕麥粒", Money = 10 },
                    new MrQueenMat { ID = "MrQueenMat004", TeaMaterialName = "統一布丁", Money = 15 },
                    new MrQueenMat { ID = "MrQueenMat005", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<MrQueenIce>().HasData(
                    new MrQueenIce { ID = "MrQueenIce001", IceName = "正常冰" },
                    new MrQueenIce { ID = "MrQueenIce002", IceName = "少冰" },
                    new MrQueenIce { ID = "MrQueenIce003", IceName = "微冰" },
                    new MrQueenIce { ID = "MrQueenIce004", IceName = "去冰" },
                    new MrQueenIce { ID = "MrQueenIce005", IceName = "溫熱" }
                );
                modelBuilder.Entity<MrQueenSug>().HasData(
                    new MrQueenSug { ID = "MrQueenSug001", SugarName = "全糖" },
                    new MrQueenSug { ID = "MrQueenSug002", SugarName = "少糖" },
                    new MrQueenSug { ID = "MrQueenSug003", SugarName = "半糖" },
                    new MrQueenSug { ID = "MrQueenSug004", SugarName = "微糖" },
                    new MrQueenSug { ID = "MrQueenSug005", SugarName = "無糖" }
                );
                //歇腳亭//
                modelBuilder.Entity<RestingPavilionFruit>().HasData(
                    new RestingPavilionFruit { ID = "RestingPavilionFruit001", Name = "爆爆水果茶2.0", Money = 70 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit002", Name = "葡萄柚綠茶", Money = 70 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit003", Name = "霸氣檸檬綠", Money = 60 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit004", Name = "霸氣柳橙綠", Money = 60 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit005", Name = "樂活百香綠+話梅", Money = 60 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit006", Name = "鳳梨果粒茶", Money = 65 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit007", Name = "芒果果粒茶", Money = 65 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit008", Name = "野莓果粒茶", Money = 65 },
                    new RestingPavilionFruit { ID = "RestingPavilionFruit009", Name = "金橙3Q鮮果茶", Money = 65 }
                );
                modelBuilder.Entity<RestingPavilionMilk>().HasData(
                    new RestingPavilionMilk { ID = "RestingPavilionMilk001", Name = "珍珠鐵觀音厚奶", Money = 70 },
                    new RestingPavilionMilk { ID = "RestingPavilionMilk002", Name = "經典厚奶紅茶", Money = 50 },
                    new RestingPavilionMilk { ID = "RestingPavilionMilk003", Name = "經典厚奶翠綠", Money = 50 },
                    new RestingPavilionMilk { ID = "RestingPavilionMilk004", Name = "鐵觀音厚奶", Money = 60 },
                    new RestingPavilionMilk { ID = "RestingPavilionMilk005", Name = "焦糖布蕾厚奶", Money = 65 }
                );
                modelBuilder.Entity<RestingPavilionTaiwan>().HasData(
                    new RestingPavilionTaiwan { ID = "RestingPavilionTaiwan001", Name = "凍頂烏龍", Money = 40 },
                    new RestingPavilionTaiwan { ID = "RestingPavilionTaiwan002", Name = "經典紅茶", Money = 30 },
                    new RestingPavilionTaiwan { ID = "RestingPavilionTaiwan003", Name = "黃金翠綠", Money = 30 },
                    new RestingPavilionTaiwan { ID = "RestingPavilionTaiwan004", Name = "南投四季春", Money = 30 },
                    new RestingPavilionTaiwan { ID = "RestingPavilionTaiwan005", Name = "高山鐵觀音", Money = 40 }
                );
                modelBuilder.Entity<RestingPavilionLatte>().HasData(
                    new RestingPavilionLatte { ID = "RestingPavilionLatte001", Name = "手搗芋頭拿鐵", Money = 80 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte002", Name = "QQ手搗芋頭奶", Money = 80 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte003", Name = "經典拿鐵紅茶", Money = 55 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte004", Name = "經典拿鐵翠綠", Money = 55 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte005", Name = "經典拿鐵鐵觀音", Money = 55 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte006", Name = "可可拿鐵", Money = 65 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte007", Name = "泰式拿鐵", Money = 65 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte008", Name = "手作綠豆沙牛奶", Money = 65 },
                    new RestingPavilionLatte { ID = "RestingPavilionLatte009", Name = "珍珠鮮奶茶", Money = 65 }
                );
                modelBuilder.Entity<RestingPavilionRemember>().HasData(
                    new RestingPavilionRemember { ID = "RestingPavilionRemember001", Name = "養樂多多綠", Money = 50 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember002", Name = "嗡嗡蜜茶", Money = 35 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember003", Name = "嗡嗡紅茶", Money = 35 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember004", Name = "嗡嗡綠茶", Money = 35 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember005", Name = "手熬冬瓜茶", Money = 35 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember006", Name = "手熬青茶", Money = 35 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember007", Name = "水水蜜桃青", Money = 40 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember008", Name = "手作綠豆雪沙", Money = 45 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember009", Name = "手熬冬瓜茶+珍珠", Money = 45 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember010", Name = "手熬冬瓜茶+粉條", Money = 45 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember011", Name = "一顆脆梅綠", Money = 45 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember012", Name = "冬瓜尬檸檬", Money = 50 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember013", Name = "蜂蜜檸檬+蘆薈", Money = 55 },
                    new RestingPavilionRemember { ID = "RestingPavilionRemember014", Name = "養樂多多檸檬綠", Money = 60 }
                );
                modelBuilder.Entity<RestingPavilionMilkCheese>().HasData(
                    new RestingPavilionMilkCheese { ID = "RestingPavilionMilkCheese001", Name = "蓋士紅茶", Money = 50 },
                    new RestingPavilionMilkCheese { ID = "RestingPavilionMilkCheese002", Name = "蓋士翠綠", Money = 50 },
                    new RestingPavilionMilkCheese { ID = "RestingPavilionMilkCheese003", Name = "蓋士鐵觀音", Money = 60 },
                    new RestingPavilionMilkCheese { ID = "RestingPavilionMilkCheese004", Name = "蓋士可可", Money = 70 }
                );
                modelBuilder.Entity<RestingPavilionGlobal>().HasData(
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal001", Name = "招牌珍奶", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal002", Name = "經典奶茶", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal003", Name = "經典奶綠", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal004", Name = "經典鐵觀音", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal005", Name = "荔枝椰果奶茶", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal006", Name = "泰式奶茶", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal007", Name = "經典可可", Money = 50 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal008", Name = "熊貓珍奶", Money = 55 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal009", Name = "小美冰淇淋紅茶", Money = 55 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal010", Name = "100分奶茶(粉條+珍珠)", Money = 55 },
                    new RestingPavilionGlobal { ID = "RestingPavilionGlobal011", Name = "手搗芋頭奶綠", Money = 60 }
                );
                modelBuilder.Entity<RestingPavilionMat>().HasData(
                    new RestingPavilionMat { ID = "RestingPavilionMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new RestingPavilionMat { ID = "RestingPavilionMat002", TeaMaterialName = "熊貓珍珠", Money = 10 },
                    new RestingPavilionMat { ID = "RestingPavilionMat003", TeaMaterialName = "粉條", Money = 10 },
                    new RestingPavilionMat { ID = "RestingPavilionMat004", TeaMaterialName = "荔枝椰果", Money = 10 },
                    new RestingPavilionMat { ID = "RestingPavilionMat005", TeaMaterialName = "茶凍", Money = 10 },
                    new RestingPavilionMat { ID = "RestingPavilionMat006", TeaMaterialName = "蘆薈", Money = 10 },
                    new RestingPavilionMat { ID = "RestingPavilionMat007", TeaMaterialName = "小美冰淇淋(2球)", Money = 15 },
                    new RestingPavilionMat { ID = "RestingPavilionMat008", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<RestingPavilionIce>().HasData(
                    new RestingPavilionIce { ID = "RestingPavilionIce001", IceName = "正常冰" },
                    new RestingPavilionIce { ID = "RestingPavilionIce002", IceName = "少冰" },
                    new RestingPavilionIce { ID = "RestingPavilionIce003", IceName = "微冰" },
                    new RestingPavilionIce { ID = "RestingPavilionIce004", IceName = "去冰(小碎冰)" },
                    new RestingPavilionIce { ID = "RestingPavilionIce005", IceName = "完全去冰" }
                );
                modelBuilder.Entity<RestingPavilionSug>().HasData(
                    new RestingPavilionSug { ID = "RestingPavilionSug001", SugarName = "全糖" },
                    new RestingPavilionSug { ID = "RestingPavilionSug002", SugarName = "少糖" },
                    new RestingPavilionSug { ID = "RestingPavilionSug003", SugarName = "半糖" },
                    new RestingPavilionSug { ID = "RestingPavilionSug004", SugarName = "微糖" },
                    new RestingPavilionSug { ID = "RestingPavilionSug005", SugarName = "無糖" }
                );
                //日出茶太//
                modelBuilder.Entity<SunriseTeaThickTeaLatte>().HasData(
                    new SunriseTeaThickTeaLatte { ID = "SunriseTeaThickTeaLatte001", Name = "太極厚茶拿鐵", Money = 70 },
                    new SunriseTeaThickTeaLatte { ID = "SunriseTeaThickTeaLatte002", Name = "熟成厚茶拿鐵", Money = 70 }
                );
                modelBuilder.Entity<SunriseTeaTeaLatte>().HasData(
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte001", Name = "珍珠紅茶拿鐵", Money = 60 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte002", Name = "熟成紅茶拿鐵", Money = 60 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte003", Name = "春摘綠茶拿鐵", Money = 60 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte004", Name = "極上焙茶拿鐵", Money = 65 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte005", Name = "鐵觀音茶拿鐵", Money = 65 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte006", Name = "莊園可可拿鐵", Money = 65 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte007", Name = "手工仙草凍鮮奶", Money = 60 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte008", Name = "黑糖珍珠鮮奶", Money = 75 },
                    new SunriseTeaTeaLatte { ID = "SunriseTeaTeaLatte009", Name = "芋泥珍珠拿鐵", Money = 85 }
                );
                modelBuilder.Entity<SunriseTeaFresh>().HasData(
                    new SunriseTeaFresh { ID = "SunriseTeaFresh001", Name = "鮮粒百香綠茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh002", Name = "鮮粒百香青茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh003", Name = "黃金芒果烏龍茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh004", Name = "黃金芒果綠茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh005", Name = "黃金芒果青茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh006", Name = "鮮榨檸檬綠茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh007", Name = "鮮榨檸檬青茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh008", Name = "葡萄柚美麗綠茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh009", Name = "葡萄柚美麗青茶", Money = 50 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh010", Name = "蔗香青茶", Money = 60 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh011", Name = "真的養樂多綠茶", Money = 55 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh012", Name = "真的養樂多青茶", Money = 55 },
                    new SunriseTeaFresh { ID = "SunriseTeaFresh013", Name = "黃金蜜香柚子茶", Money = 60 }
                );
                modelBuilder.Entity<SunriseTeaMilk>().HasData(
                    new SunriseTeaMilk { ID = "SunriseTeaMilk001", Name = "太極珍珠奶茶", Money = 55 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk002", Name = "太極粉粿珍奶", Money = 65 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk003", Name = "紅豆粉粿珍奶", Money = 60 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk004", Name = "烏龍奶三寶(椰果+粉粿+珍珠)", Money = 60 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk005", Name = "日不落經典奶茶", Money = 45 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk006", Name = "日不落珍珠奶茶", Money = 50 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk007", Name = "雲霧烏龍奶茶", Money = 50 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk008", Name = "Q嫩布丁奶茶", Money = 55 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk009", Name = "極上特選烤奶", Money = 50 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk010", Name = "莊園可可", Money = 60 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk011", Name = "手作芋泥奶茶", Money = 55 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk012", Name = "春摘奶綠", Money = 50 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk013", Name = "四季春奶蓋", Money = 55 },
                    new SunriseTeaMilk { ID = "SunriseTeaMilk014", Name = "雲霧烏龍奶蓋", Money = 55 }
                );
                modelBuilder.Entity<SunriseTeaHealthy>().HasData(
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy001", Name = "秘釀冬瓜茶", Money = 30 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy002", Name = "鮮榨檸檬冬瓜", Money = 45 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy003", Name = "信義梅子露", Money = 45 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy004", Name = "鮮粒百香QQ", Money = 55 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy005", Name = "黃金芒果QQ", Money = 55 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy006", Name = "鮮榨檸檬蜜", Money = 55 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy007", Name = "蔗香鮮榨檸檬", Money = 60 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy008", Name = "養樂多檸檬", Money = 65 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy009", Name = "養樂多百香", Money = 65 },
                    new SunriseTeaHealthy { ID = "SunriseTeaHealthy010", Name = "紫玫瑰荔枝凍飲", Money = 65 }
                );
                modelBuilder.Entity<SunriseTeaCorridor>().HasData(
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor001", Name = "日出璞玉紅茶", Money = 30 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor002", Name = "春摘綠茶", Money = 30 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor003", Name = "四季春青茶", Money = 30 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor004", Name = "極上焙茶", Money = 35 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor005", Name = "雲霧烏龍茶", Money = 35 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor006", Name = "台茶12金萱", Money = 45 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor007", Name = "焙香鐵觀音", Money = 45 },
                    new SunriseTeaCorridor { ID = "SunriseTeaCorridor008", Name = "東方美人", Money = 45 }
                );
                modelBuilder.Entity<SunriseTeaMat>().HasData(
                    new SunriseTeaMat { ID = "SunriseTeaMat001", TeaMaterialName = "黑珍珠", Money = 5 },
                    new SunriseTeaMat { ID = "SunriseTeaMat002", TeaMaterialName = "仙草凍", Money = 5 },
                    new SunriseTeaMat { ID = "SunriseTeaMat003", TeaMaterialName = "太極珍珠", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat004", TeaMaterialName = "蒟蒻晶球", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat005", TeaMaterialName = "椰果", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat006", TeaMaterialName = "粉粿 ", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat007", TeaMaterialName = "布丁", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat008", TeaMaterialName = "QQ", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat009", TeaMaterialName = "紅豆", Money = 10 },
                    new SunriseTeaMat { ID = "SunriseTeaMat010", TeaMaterialName = "芋泥 ", Money = 15 },
                    new SunriseTeaMat { ID = "SunriseTeaMat011", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<SunriseTeaIce>().HasData(
                    new SunriseTeaIce { ID = "SunriseTeaIce001", IceName = "正常冰" },
                    new SunriseTeaIce { ID = "SunriseTeaIce002", IceName = "少冰" },
                    new SunriseTeaIce { ID = "SunriseTeaIce003", IceName = "微冰" },
                    new SunriseTeaIce { ID = "SunriseTeaIce004", IceName = "去冰" }
                );
                modelBuilder.Entity<SunriseTeaSug>().HasData(
                    new SunriseTeaSug { ID = "SunriseTeaSug001", SugarName = "正常糖" },
                    new SunriseTeaSug { ID = "SunriseTeaSug002", SugarName = "半糖" },
                    new SunriseTeaSug { ID = "SunriseTeaSug003", SugarName = "微糖" },
                    new SunriseTeaSug { ID = "SunriseTeaSug006", SugarName = "無糖" }
                );
                //老賴茶棧//
                modelBuilder.Entity<LaiTeaBag>().HasData(
                    new LaiTeaBag { ID = "LaiTeaBag001", Name = "台灣茶后茶包(10入一盒)", Money = 149 }
                );
                modelBuilder.Entity<LaiFacia>().HasData(
                    new LaiFacia { ID = "LaiFacia001", Name = "老賴紅茶", Money1 = 35, Money2 = 65 },
                    new LaiFacia { ID = "LaiFacia002", Name = "豆香紅茶", Money1 = 55, Money2 = 65 },
                    new LaiFacia { ID = "LaiFacia003", Name = "太后牛乳", Money1 = 65, Money2 = 65 },
                    new LaiFacia { ID = "LaiFacia004", Name = "珍珠紅茶", Money1 = 45, Money2 = 60 },
                    new LaiFacia { ID = "LaiFacia005", Name = "珍珠奶茶", Money1 = 55, Money2 = 70 },
                    new LaiFacia { ID = "LaiFacia006", Name = "烏梅紅茶", Money1 = 50, Money2 = 70 },
                    new LaiFacia { ID = "LaiFacia007", Name = "冬瓜檸檬", Money1 = 55, Money2 = 70 },
                    new LaiFacia { ID = "LaiFacia008", Name = "青草紅茶(不可加料)", Money1 = 50, Money2 = 70 }
                );
                modelBuilder.Entity<LaiTea>().HasData(
                    new LaiTea { ID = "LaiTea001", Name = "四季青茶", Money1 = 35 },
                    new LaiTea { ID = "LaiTea002", Name = "茉翠香綠", Money1 = 35 },
                    new LaiTea { ID = "LaiTea003", Name = "青霧綠茶", Money1 = 35, Money2 = 115 }
                );
                modelBuilder.Entity<LaiMilkTea>().HasData(
                    new LaiMilkTea { ID = "LaiMilkTea001", Name = "招牌奶茶", Money1 = 55, Money2 = 175 }, 
                    new LaiMilkTea { ID = "LaiMilkTea002", Name = "胚芽奶茶", Money1 = 65 },
                    new LaiMilkTea { ID = "LaiMilkTea003", Name = "布丁奶茶", Money1 = 65 },
                    new LaiMilkTea { ID = "LaiMilkTea004", Name = "椰果奶茶", Money2 = 65 },
                    new LaiMilkTea { ID = "LaiMilkTea005", Name = "香綠奶茶", Money2 = 55 },
                    new LaiMilkTea { ID = "LaiMilkTea006", Name = "珍珠綠奶", Money1 = 55 },
                    new LaiMilkTea { ID = "LaiMilkTea007", Name = "布丁綠奶", Money1 = 65 },
                    new LaiMilkTea { ID = "LaiMilkTea008", Name = "珍珠胚芽奶茶", Money2 = 65 },
                    new LaiMilkTea { ID = "LaiMilkTea009", Name = "珍珠布丁奶茶", Money2 = 70 }
                );
                modelBuilder.Entity<LaiAncient>().HasData(
                    new LaiAncient { ID = "LaiAncient001", Name = "手工豆漿", Money1 = 55, Money2 = 175 },
                    new LaiAncient { ID = "LaiAncient002", Name = "熬煮青草茶(不可加料)", Money1 = 50, Money2 = 160 }
                );
                modelBuilder.Entity<LaiOolong>().HasData(
                    new LaiOolong { ID = "LaiOolong001", Name = "文清烏龍", Money1 = 35, Money2 = 115 },
                    new LaiOolong { ID = "LaiOolong002", Name = "文清冬瓜", Money1 = 40, Money2 = 130 },
                    new LaiOolong { ID = "LaiOolong003", Name = "文清檸檬", Money1 = 50, Money2 = 160 },
                    new LaiOolong { ID = "LaiOolong004", Name = "文清阿梅", Money1 = 55, Money2 = 175 },
                    new LaiOolong { ID = "LaiOolong005", Name = "文清樂多(不可加料)", Money1 = 55 }
                );
                modelBuilder.Entity<LaiWinterMelon>().HasData(
                    new LaiWinterMelon { ID = "LaiWinterMelon001", Name = "熬煮冬瓜茶", Money1 = 40, Money2 = 130 },
                    new LaiWinterMelon { ID = "LaiWinterMelon002", Name = "冬瓜紅茶", Money1 = 40, Money2 = 130 },
                    new LaiWinterMelon { ID = "LaiWinterMelon003", Name = "冬瓜青霧", Money1 = 40, Money2 = 130 },
                    new LaiWinterMelon { ID = "LaiWinterMelon004", Name = "冬瓜香青", Money1 = 40 },
                    new LaiWinterMelon { ID = "LaiWinterMelon005", Name = "冬瓜香綠", Money1 = 40 },
                    new LaiWinterMelon { ID = "LaiWinterMelon006", Name = "愛玉冬瓜檸檬", Money1 = 65 }
                );
                modelBuilder.Entity<LaiQueen>().HasData(
                    new LaiQueen { ID = "LaiQueen001", Name = "太后冬瓜奶", Money1 = 65, Money2 = 205 },
                    new LaiQueen { ID = "LaiQueen002", Name = "太后香綠奶", Money1 = 65 },
                    new LaiQueen { ID = "LaiQueen003", Name = "珍珠太后牛乳", Money1 = 70 },
                    new LaiQueen { ID = "LaiQueen004", Name = "布丁太后牛乳", Money1 = 75 }
                ); 
                modelBuilder.Entity<LaiTune>().HasData(
                    new LaiTune { ID = "LaiTune001", Name = "青檸紅茶", Money1 = 50, Money2 = 160 },
                    new LaiTune { ID = "LaiTune002", Name = "青檸青霧綠茶", Money1 = 50, Money2 = 160 },
                    new LaiTune { ID = "LaiTune003", Name = "青檸香綠茶", Money1 = 50 },
                    new LaiTune { ID = "LaiTune004", Name = "青檸香青茶", Money1 = 50 },
                    new LaiTune { ID = "LaiTune005", Name = "玉檸香綠茶(不可加料)", Money1 = 60 },
                    new LaiTune { ID = "LaiTune006", Name = "樂多香綠茶(不可加料)", Money1 = 55 },
                    new LaiTune { ID = "LaiTune007", Name = "樂多香青茶(不可加料)", Money1 = 55 }
                );
                modelBuilder.Entity<LaiSesame>().HasData(
                    new LaiSesame { ID = "LaiSesame001", Name = "黑芝麻豆漿(不可加料)", Money1 = 65 },
                    new LaiSesame { ID = "LaiSesame002", Name = "黑芝麻奶茶(不可加料)", Money1 = 65 },
                    new LaiSesame { ID = "LaiSesame003", Name = "黑芝麻珍珠奶茶(不可加料)", Money1 = 70 },
                    new LaiSesame { ID = "LaiSesame004", Name = "黑芝麻胚芽奶茶(不可加料)", Money1 = 75 },
                    new LaiSesame { ID = "LaiSesame005", Name = "黑芝麻太后牛乳(不可加料)",Money1 = 80 },
                    new LaiSesame { ID = "LaiSesame006", Name = "黑芝麻珍珠太后牛乳(不可加料)", Money1 = 85 }
                );
                modelBuilder.Entity<LaiMat>().HasData(
                    new LaiMat { ID = "LaiMat001", TeaMaterialName = "珍珠", Money = 10 },
                    new LaiMat { ID = "LaiMat002", TeaMaterialName = "茶凍", Money = 20 },
                    new LaiMat { ID = "LaiMat003", TeaMaterialName = "胚芽", Money = 10 },
                    new LaiMat { ID = "LaiMat004", TeaMaterialName = "椰果", Money = 10 },
                    new LaiMat { ID = "LaiMat005", TeaMaterialName = "愛玉", Money = 10 },
                    new LaiMat { ID = "LaiMat006", TeaMaterialName = "布丁", Money = 15 },
                    new LaiMat { ID = "LaiMat007", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<LaiIce>().HasData(
                    new LaiIce { ID = "LaiIce001", IceName = "正常冰" },
                    new LaiIce { ID = "LaiIce002", IceName = "少冰" },
                    new LaiIce { ID = "LaiIce003", IceName = "微冰" },
                    new LaiIce { ID = "LaiIce004", IceName = "去冰" },
                    new LaiIce { ID = "LaiIce005", IceName = "完全去冰" }
                );
                modelBuilder.Entity<LaiSug>().HasData(
                    new LaiSug { ID = "LaiSug001", SugarName = "正常糖" },
                    new LaiSug { ID = "LaiSug002", SugarName = "半糖" },
                    new LaiSug { ID = "LaiSug003", SugarName = "微糖" },
                    new LaiSug { ID = "LaiSug004", SugarName = "一分糖" },
                    new LaiSug { ID = "LaiSug005", SugarName = "無糖" }
                );
                //武林茶//
                modelBuilder.Entity<WulinSoul>().HasData(
                    new WulinSoul { ID = "WulinSoul001", Name = "招牌雙茶檸檬 (甜冰固定)", Money = 60 },
                    new WulinSoul { ID = "WulinSoul002", Name = "啡香檸檬", Money = 65 },
                    new WulinSoul { ID = "WulinSoul003", Name = "啡香紅茶", Money = 65 },
                    new WulinSoul { ID = "WulinSoul004", Name = "啡香翠玉", Money = 65 },
                    new WulinSoul { ID = "WulinSoul005", Name = "啡香凍頂", Money = 65 },
                    new WulinSoul { ID = "WulinSoul006", Name = "檸檬宏白木耳飲", Money = 70 },
                    new WulinSoul { ID = "WulinSoul007", Name = "幼幼班檸檬茶", Money = 60 },
                    new WulinSoul { ID = "WulinSoul008", Name = "桂花檸檬露", Money = 60 },
                    new WulinSoul { ID = "WulinSoul009", Name = "冬瓜檸檬", Money = 60 },
                    new WulinSoul { ID = "WulinSoul010", Name = "凍頂檸檬多酚", Money = 75 }
                );
                modelBuilder.Entity<WulinSpecialBlend>().HasData(
                    new WulinSpecialBlend { ID = "WulinSpecialBlend001", Name = "茶多酚金萱", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend002", Name = "茶多酚綠茶", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend003", Name = "茶多多金萱", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend004", Name = "茶多多綠茶", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend005", Name = "四季荔荔", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend006", Name = "蘋果迎春", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend007", Name = "楊桃烏龍", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend008", Name = "武冰綠", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend009", Name = "武仙甘茶", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend010", Name = "凍頂烏龍梅果", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend011", Name = "青梅胭脂紅", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend012", Name = "凍頂桂花烏龍", Money = 60 },
                    new WulinSpecialBlend { ID = "WulinSpecialBlend013", Name = "胭脂桂花紅", Money = 60 }
                );
                modelBuilder.Entity<WulinFifty>().HasData(
                    new WulinFifty { ID = "WulinFifty001", Name = "凍頂山烏龍茶(研萃手沖)", Money = 35 },
                    new WulinFifty { ID = "WulinFifty002", Name = "凍頂山烏龍茶(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty003", Name = "凍頂山烏龍茶(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty004", Name = "凍頂山烏龍茶(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty005", Name = "杉夏露高山青茶(研萃手沖)", Money = 35 },
                    new WulinFifty { ID = "WulinFifty006", Name = "杉夏露高山青茶(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty007", Name = "杉夏露高山青茶(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty008", Name = "杉夏露高山青茶(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty009", Name = "臺灣四季春(研萃手沖)", Money = 35 },
                    new WulinFifty { ID = "WulinFifty010", Name = "臺灣四季春(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty011", Name = "臺灣四季春(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty012", Name = "臺灣四季春(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty013", Name = "金萱烏龍(研萃手沖)", Money = 35 },
                    new WulinFifty { ID = "WulinFifty014", Name = "金萱烏龍(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty015", Name = "金萱烏龍(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty016", Name = "金萱烏龍(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty017", Name = "霂灆紅茶(研萃手沖)", Money = 35 },
                    new WulinFifty { ID = "WulinFifty018", Name = "霂灆紅茶(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty019", Name = "霂灆紅茶(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty020", Name = "霂灆紅茶(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty021", Name = "冬瓜風味茶(研萃手沖)", Money = 35 },
                    new WulinFifty { ID = "WulinFifty022", Name = "冬瓜風味茶(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty023", Name = "冬瓜風味茶(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty024", Name = "冬瓜風味茶(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty025", Name = "凍頂碳焙烏龍(研萃手沖)", Money = 40 },
                    new WulinFifty { ID = "WulinFifty026", Name = "凍頂碳焙烏龍(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty027", Name = "凍頂碳焙烏龍(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty028", Name = "凍頂碳焙烏龍(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty029", Name = "翡冷綠(研萃手沖)", Money = 40 },
                    new WulinFifty { ID = "WulinFifty030", Name = "翡冷綠(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty031", Name = "翡冷綠(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty032", Name = "翡冷綠(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty033", Name = "翠玉迎春(研萃手沖)", Money = 40 },
                    new WulinFifty { ID = "WulinFifty034", Name = "翠玉迎春(奶蓋微冰)", Money = 60 },
                    new WulinFifty { ID = "WulinFifty035", Name = "翠玉迎春(重茶輕乳)", Money = 70 },
                    new WulinFifty { ID = "WulinFifty036", Name = "翠玉迎春(重乳輕茶)", Money = 80 },
                    new WulinFifty { ID = "WulinFifty037", Name = "小山抹茶(研萃手沖)", Money = 50 },
                    new WulinFifty { ID = "WulinFifty038", Name = "小山抹茶(奶蓋微冰)", Money = 65 },
                    new WulinFifty { ID = "WulinFifty039", Name = "小山抹茶(重茶輕乳)", Money = 75 },
                    new WulinFifty { ID = "WulinFifty040", Name = "小山抹茶(重乳輕茶)", Money = 85 }
                );
                modelBuilder.Entity<WulinMaterial>().HasData(
                    new WulinMaterial { ID = "WulinMaterial001", Name = "焙茶皇金磚", Money = 55 },
                    new WulinMaterial { ID = "WulinMaterial002", Name = "蘋果皇金磚", Money = 65 },
                    new WulinMaterial { ID = "WulinMaterial003", Name = "冬瓜仙草皇金磚", Money = 60 },
                    new WulinMaterial { ID = "WulinMaterial004", Name = "金萱舞凍", Money = 60 },
                    new WulinMaterial { ID = "WulinMaterial005", Name = "金萱舞Q", Money = 50 },
                    new WulinMaterial { ID = "WulinMaterial006", Name = "銀耳舞Q", Money = 50 },
                    new WulinMaterial { ID = "WulinMaterial007", Name = "冬瓜三兄弟", Money = 50 },
                    new WulinMaterial { ID = "WulinMaterial008", Name = "凍頂檸檬霸", Money = 70 },
                    new WulinMaterial { ID = "WulinMaterial009", Name = "翡冷綠百香Q霸", Money = 70 },
                    new WulinMaterial { ID = "WulinMaterial010", Name = "甘蔗珍波白木耳飲", Money = 70 },
                    new WulinMaterial { ID = "WulinMaterial011", Name = "胭脂桂花紅白木耳飲", Money = 70 },
                    new WulinMaterial { ID = "WulinMaterial012", Name = "鳳梨白木耳飲", Money = 70 }
                );
                modelBuilder.Entity<WulinFruit>().HasData(
                    new WulinFruit { ID = "WulinFruit001", Name = "凍春山", Money = 80 },
                    new WulinFruit { ID = "WulinFruit002", Name = "凍頂紅鑽葡萄柚", Money = 75 },
                    new WulinFruit { ID = "WulinFruit003", Name = "金萱鮮橙百香飲", Money = 80 },
                    new WulinFruit { ID = "WulinFruit004", Name = "柳橙多多檸檬凍飲", Money = 80 },
                    new WulinFruit { ID = "WulinFruit005", Name = "葡萄柚多酚", Money = 80 },
                    new WulinFruit { ID = "WulinFruit006", Name = "葡萄柚多多", Money = 80 },
                    new WulinFruit { ID = "WulinFruit007", Name = "紅柚楊桃露", Money = 80 },
                    new WulinFruit { ID = "WulinFruit008", Name = "杉夏露柳橙青", Money = 75 },
                    new WulinFruit { ID = "WulinFruit009", Name = "杉芭青茶", Money = 70 },
                    new WulinFruit { ID = "WulinFruit010", Name = "杉夏露甘蔗青", Money = 65 },
                    new WulinFruit { ID = "WulinFruit011", Name = "蜜香甘蔗紅", Money = 65 },
                    new WulinFruit { ID = "WulinFruit012", Name = "四季春鳳梨茶", Money = 65 },
                    new WulinFruit { ID = "WulinFruit013", Name = "蜜香旺萊紅", Money = 65 },
                    new WulinFruit { ID = "WulinFruit014", Name = "啡香金桔檸檬茶", Money = 70 },
                    new WulinFruit { ID = "WulinFruit015", Name = "凍頂金桔檸檬", Money = 70 },
                    new WulinFruit { ID = "WulinFruit016", Name = "凍頂檸檬蘆薈", Money = 70 },
                    new WulinFruit { ID = "WulinFruit017", Name = "凍頂檸檬晶凍飲", Money = 70 },
                    new WulinFruit { ID = "WulinFruit018", Name = "鮮百香果茶", Money = 65 },
                    new WulinFruit { ID = "WulinFruit019", Name = "四季春百香蘆薈飲", Money = 75 },
                    new WulinFruit { ID = "WulinFruit020", Name = "鳳梨皇金磚莎莎", Money = 90 },
                    new WulinFruit { ID = "WulinFruit021", Name = "蘋果皇金磚莎莎", Money = 90 }
                );
                modelBuilder.Entity<WulinMilkTea>().HasData(
                    new WulinMilkTea { ID = "WulinMilkTea001", Name = "霂灆奶茶", Money = 60 },
                    new WulinMilkTea { ID = "WulinMilkTea002", Name = "碳香珍波奶茶", Money = 65 },
                    new WulinMilkTea { ID = "WulinMilkTea003", Name = "雙焙奶茶皇金磚", Money = 70 },
                    new WulinMilkTea { ID = "WulinMilkTea004", Name = "碳焙烤茶晶凍奶", Money = 70 },
                    new WulinMilkTea { ID = "WulinMilkTea005", Name = "碳焙珍波晶凍奶", Money = 70 },
                    new WulinMilkTea { ID = "WulinMilkTea006", Name = "金萱舞Ｑ醇奶茶", Money = 70 },
                    new WulinMilkTea { ID = "WulinMilkTea007", Name = "泰紅", Money = 65 },
                    new WulinMilkTea { ID = "WulinMilkTea008", Name = "泰紅皇金磚", Money = 80 },
                    new WulinMilkTea { ID = "WulinMilkTea009", Name = "四季春椰果奶", Money = 65 },
                    new WulinMilkTea { ID = "WulinMilkTea010", Name = "桂花奶茶", Money = 65 },
                    new WulinMilkTea { ID = "WulinMilkTea011", Name = "仙草奶凍", Money = 65 },
                    new WulinMilkTea { ID = "WulinMilkTea012", Name = "阿華田奶茶", Money = 70 },
                    new WulinMilkTea { ID = "WulinMilkTea013", Name = "黑糖風味焙茶烤奶", Money = 65 },
                    new WulinMilkTea { ID = "WulinMilkTea014", Name = "抹茶奶茶", Money = 65 }
                );
                modelBuilder.Entity<WulinPurple>().HasData(
                    new WulinPurple { ID = "WulinPurple001", Name = "紫心牛奶", Money1 = 70 },
                    new WulinPurple { ID = "WulinPurple002", Name = "珍波紫心牛奶", Money2 = 75 },
                    new WulinPurple { ID = "WulinPurple003", Name = "紫芋薯牛奶", Money2 = 75 },
                    new WulinPurple { ID = "WulinPurple004", Name = "芋頭牛奶", Money1 = 70 },
                    new WulinPurple { ID = "WulinPurple005", Name = "金萱芋頭奶", Money2 = 70 },
                    new WulinPurple { ID = "WulinPurple006", Name = "金萱芋頭珍波奶", Money2 = 75 }
                );
                modelBuilder.Entity<WulinMat>().HasData(
                    new WulinMat { ID = "WulinMat001", TeaMaterialName = "珍波", Money = 5 },
                    new WulinMat { ID = "WulinMat002", TeaMaterialName = "椰果", Money = 5 },
                    new WulinMat { ID = "WulinMat003", TeaMaterialName = "Q纖果", Money = 5 },
                    new WulinMat { ID = "WulinMat004", TeaMaterialName = "甘甜梅", Money = 5 },
                    new WulinMat { ID = "WulinMat005", TeaMaterialName = "蘆薈", Money = 10 },
                    new WulinMat { ID = "WulinMat006", TeaMaterialName = "白晶晶", Money = 10 },
                    new WulinMat { ID = "WulinMat007", TeaMaterialName = "黑晶晶", Money = 10 },
                    new WulinMat { ID = "WulinMat008", TeaMaterialName = "檸檬棟", Money = 15 },
                    new WulinMat { ID = "WulinMat009", TeaMaterialName = "焙茶凍", Money = 15 },
                    new WulinMat { ID = "WulinMat010", TeaMaterialName = "蘋果凍", Money = 15 },
                    new WulinMat { ID = "WulinMat011", TeaMaterialName = "仙草凍", Money = 15 },
                    new WulinMat { ID = "WulinMat012", TeaMaterialName = "珍椰Q", Money = 15 },
                    new WulinMat { ID = "WulinMat013", TeaMaterialName = "白木耳", Money = 15 },
                    new WulinMat { ID = "WulinMat014", TeaMaterialName = "黑白Q", Money = 15 },
                    new WulinMat { ID = "WulinMat015", TeaMaterialName = "乳香鹹奶蓋", Money = 15 },
                    new WulinMat { ID = "WulinMat016", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<WulinIce>().HasData(
                    new WulinIce { ID = "WulinIce001", IceName = "全冰(70%)" },
                    new WulinIce { ID = "WulinIce002", IceName = "半冰(50%)" },
                    new WulinIce { ID = "WulinIce003", IceName = "少冰(40%)" },
                    new WulinIce { ID = "WulinIce004", IceName = "微冰(20%)" },
                    new WulinIce { ID = "WulinIce005", IceName = "去冰(2%)" }
                );
                modelBuilder.Entity<WulinSug>().HasData(
                    new WulinSug { ID = "WulinSug001", SugarName = "全糖" },
                    new WulinSug { ID = "WulinSug002", SugarName = "七分(70%)" },
                    new WulinSug { ID = "WulinSug003", SugarName = "半糖(50%)" },
                    new WulinSug { ID = "WulinSug004", SugarName = "微糖(30%)" },
                    new WulinSug { ID = "WulinSug005", SugarName = "一分(10%)" },
                    new WulinSug { ID = "WulinSug006", SugarName = "提味(3%)" },
                    new WulinSug { ID = "WulinSug007", SugarName = "無糖(0%)" }
                );
                //Tea's原味//
                modelBuilder.Entity<TeasOriginalTea>().HasData(
                    new TeasOriginalTea { ID = "TeasOriginalTea001", Name = "阿里山香片",Money = 25, Money1 = 30, Money2 = 50 },
                    new TeasOriginalTea { ID = "TeasOriginalTea002", Name = "伯爵紅茶", Money = 20, Money1 = 25, Money2 = 45 },
                    new TeasOriginalTea { ID = "TeasOriginalTea003", Name = "古早味紅茶", Money = 20, Money1 = 25, Money2 = 45 },
                    new TeasOriginalTea { ID = "TeasOriginalTea004", Name = "炭焙麥茶", Money = 20, Money1 = 25, Money2 = 45 },
                    new TeasOriginalTea { ID = "TeasOriginalTea005", Name = "高纖綠茶", Money = 25, Money1 = 30, Money2 = 50 },
                    new TeasOriginalTea { ID = "TeasOriginalTea006", Name = "文山青茶", Money = 25, Money1 = 30, Money2 = 50 },
                    new TeasOriginalTea { ID = "TeasOriginalTea007", Name = "烏龍青茶", Money = 25, Money1 = 30, Money2 = 50 },
                    new TeasOriginalTea { ID = "TeasOriginalTea008", Name = "鐵觀音烏龍茶", Money = 25, Money1 = 30, Money2 = 50 },
                    new TeasOriginalTea { ID = "TeasOriginalTea009", Name = "冬瓜青茶", Money = 30, Money1 = 35, Money2 = 55 },
                    new TeasOriginalTea { ID = "TeasOriginalTea010", Name = "古早味冬瓜", Money = 30, Money1 = 35, Money2 = 55 },
                    new TeasOriginalTea { ID = "TeasOriginalTea011", Name = "洛神花茶", Money = 30, Money1 = 35, Money2 = 55 },
                    new TeasOriginalTea { ID = "TeasOriginalTea012", Name = "仙草干茶", Money = 25, Money1 = 30, Money2 = 50 }
                );
                modelBuilder.Entity<TeasOriginalChew>().HasData(
                    new TeasOriginalChew { ID = "TeasOriginalChew001", Name = "紅茶三兄弟", Money1 = 60 },
                    new TeasOriginalChew { ID = "TeasOriginalChew002", Name = "蜂蜜蘆薈", Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew003", Name = "波霸奶茶", Money = 35, Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew004", Name = "波霸奶綠", Money = 35, Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew005", Name = "小珍珠奶茶", Money = 35, Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew006", Name = "小珍珠奶綠", Money = 35, Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew007", Name = "雙珠奶茶", Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew008", Name = "雙珠奶綠", Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew009", Name = "雙Q奶茶", Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew010", Name = "椰果奶茶", Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew011", Name = "椰果咖啡凍奶茶", Money1 = 45, Money2 = 75 },
                    new TeasOriginalChew { ID = "TeasOriginalChew012", Name = "冬瓜愛玉", Money1 = 45 },
                    new TeasOriginalChew { ID = "TeasOriginalChew013", Name = "愛玉冰茶", Money1 = 45 },
                    new TeasOriginalChew { ID = "TeasOriginalChew014", Name = "布丁奶茶", Money1 = 50 },
                    new TeasOriginalChew { ID = "TeasOriginalChew015", Name = "檸檬愛玉", Money1 = 55 },
                    new TeasOriginalChew { ID = "TeasOriginalChew016", Name = "仙草凍奶茶", Money1 = 45 },
                    new TeasOriginalChew { ID = "TeasOriginalChew017", Name = "奶茶三兄弟", Money1 = 60 },
                    new TeasOriginalChew { ID = "TeasOriginalChew018", Name = "圓圓奶茶", Money1 = 45 },
                    new TeasOriginalChew { ID = "TeasOriginalChew019", Name = "圓圓鮮奶茶", Money1 = 60 },
                    new TeasOriginalChew { ID = "TeasOriginalChew020", Name = "焦糖布蕾珍奶", Money1 = 70 }
                );
                modelBuilder.Entity<TeasOriginalMilkAroma>().HasData(
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma001", Name = "奶茶", Money = 25, Money1 = 35, Money2 = 65 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma002", Name = "奶綠", Money = 25, Money1 = 35, Money2 = 65 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma003", Name = "烏龍奶茶", Money = 25, Money1 = 35, Money2 = 65 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma004", Name = "芋香奶茶", Money1 = 45 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma005", Name = "黑糖奶茶", Money1 = 45, Money2 = 75 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma006", Name = "巧克力可可", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma007", Name = "阿華田", Money1 = 45, Money2 = 75 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma008", Name = "焦糖奶茶", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma009", Name = "冰淇淋紅茶", Money1 = 50 },
                    new TeasOriginalMilkAroma { ID = "TeasOriginalMilkAroma010", Name = "金牌冰咖啡", Money1 = 50 }
                );
                modelBuilder.Entity<TeasOriginalFruit>().HasData(
                    new TeasOriginalFruit { ID = "TeasOriginalFruit001", Name = "鮮桔茶", Money1 = 45, Money2 = 75 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit002", Name = "檸檬汁", Money1 = 45, Money2 = 75 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit003", Name = "情人茶", Money1 = 50 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit004", Name = "冬瓜檸檬", Money1 = 50, Money2 = 80 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit005", Name = "蜂蜜檸檬", Money1 = 50, Money2 = 80 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit006", Name = "檸檬梅子", Money1 = 45 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit007", Name = "檸檬多多", Money1 = 55 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit008", Name = "港式凍檸茶", Money1 = 50, Money2 = 80 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit009", Name = "百香綠茶", Money1 = 50, Money2 = 80 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit010", Name = "百香紅茶", Money1 = 50, Money2 = 80 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit011", Name = "金桔檸檬", Money1 = 50, Money2 = 80 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit012", Name = "鮮葡萄柚綠茶", Money1 = 60 },
                    new TeasOriginalFruit { ID = "TeasOriginalFruit013", Name = "鮮柳橙綠茶", Money1 = 60 }
                );
                modelBuilder.Entity<TeasOriginalSpecialBlend>().HasData(
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend001", Name = "梅子綠茶", Money1 = 40, Money2 = 65 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend002", Name = "梅子紅茶", Money1 = 40, Money2 = 65 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend003", Name = "蜂蜜茶", Money1 = 40, Money2 = 70 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend004", Name = "蜂蜜綠茶", Money1 = 40, Money2 = 70 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend005", Name = "蜂蜜紅茶", Money1 = 40, Money2 = 70 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend006", Name = "綠茶多多", Money1 = 40 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend007", Name = "芒果綠茶", Money1 = 50 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend008", Name = "芒果青茶", Money1 = 50 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend009", Name = "海尼根綠茶", Money1 = 50 },
                    new TeasOriginalSpecialBlend { ID = "TeasOriginalSpecialBlend010", Name = "長島冰茶", Money1 = 50 }
                );
                modelBuilder.Entity<TeasOriginalJapan>().HasData(
                    new TeasOriginalJapan { ID = "TeasOriginalJapan001", Name = "靜岡抹茶拿鐵", Money1 = 50 },
                    new TeasOriginalJapan { ID = "TeasOriginalJapan002", Name = "靜岡抹茶波霸冰淇淋", Money1 = 60 }
                );
                modelBuilder.Entity<TeasOriginalMilk>().HasData(
                    new TeasOriginalMilk { ID = "TeasOriginalMilk001", Name = "芝士奶蓋紅", Money1 = 50 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk002", Name = "芝士奶蓋綠", Money1 = 50 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk003", Name = "綠茶拿鐵", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk004", Name = "紅茶拿鐵", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk005", Name = "鐵觀音拿鐵", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk006", Name = "冬瓜鮮奶", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk007", Name = "鮮奶仙草凍", Money1 = 55 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk008", Name = "黑糖鮮奶茶", Money1 = 50, Money2 = 80 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk009", Name = "波霸紅茶拿鐵", Money1 = 60 },
                    new TeasOriginalMilk { ID = "TeasOriginalMilk010", Name = "波霸綠茶拿鐵", Money1 = 60 }
                );
                modelBuilder.Entity<TeasOriginalHot>().HasData(
                    new TeasOriginalHot { ID = "TeasOriginalHot001", Name = "熱黑糖奶茶", Money = 45 },
                    new TeasOriginalHot { ID = "TeasOriginalHot002", Name = "熱桔茶", Money = 45 },
                    new TeasOriginalHot { ID = "TeasOriginalHot003", Name = "黑糖薑茶", Money = 35, Money1 = 40 },
                    new TeasOriginalHot { ID = "TeasOriginalHot004", Name = "桂圓薑母", Money = 40, Money1 = 45 },
                    new TeasOriginalHot { ID = "TeasOriginalHot005", Name = "桂圓紅棗", Money = 40, Money1 = 45 },
                    new TeasOriginalHot { ID = "TeasOriginalHot006", Name = "薑汁熱鮮奶", Money = 45, Money1 = 55 },
                    new TeasOriginalHot { ID = "TeasOriginalHot007", Name = "桂圓奶茶", Money = 45, Money1 = 50 },
                    new TeasOriginalHot { ID = "TeasOriginalHot008", Name = "熱巧克力可可", Money = 50 },
                    new TeasOriginalHot { ID = "TeasOriginalHot009", Name = "熱阿華田", Money = 45 },
                    new TeasOriginalHot { ID = "TeasOriginalHot010", Name = "金牌熱咖啡", Money = 50 }
                );
                modelBuilder.Entity<TeasOriginalMat>().HasData(
                    new TeasOriginalMat { ID = "TeasOriginalMat001", TeaMaterialName = "波霸", Money = 10 },
                    new TeasOriginalMat { ID = "TeasOriginalMat002", TeaMaterialName = "小珍珠", Money = 20 },
                    new TeasOriginalMat { ID = "TeasOriginalMat003", TeaMaterialName = "仙草凍", Money = 10 },
                    new TeasOriginalMat { ID = "TeasOriginalMat004", TeaMaterialName = "蘆薈", Money = 10 },
                    new TeasOriginalMat { ID = "TeasOriginalMat005", TeaMaterialName = "咖啡凍", Money = 10 },
                    new TeasOriginalMat { ID = "TeasOriginalMat006", TeaMaterialName = "椰果", Money = 10 },
                    new TeasOriginalMat { ID = "TeasOriginalMat007", TeaMaterialName = "雙Q", Money = 10 },
                    new TeasOriginalMat { ID = "TeasOriginalMat008", TeaMaterialName = "愛玉", Money = 15 },
                    new TeasOriginalMat { ID = "TeasOriginalMat009", TeaMaterialName = "布丁", Money = 15 },
                    new TeasOriginalMat { ID = "TeasOriginalMat010", TeaMaterialName = "圓圓(芋圓+地瓜圓)", Money = 15 },
                    new TeasOriginalMat { ID = "TeasOriginalMat011", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<TeasOriginalIce>().HasData(
                    new TeasOriginalIce { ID = "TeasOriginalIce001", IceName = "正常冰" },
                    new TeasOriginalIce { ID = "TeasOriginalIce002", IceName = "少冰" },
                    new TeasOriginalIce { ID = "TeasOriginalIce003", IceName = "微冰" },
                    new TeasOriginalIce { ID = "TeasOriginalIce004", IceName = "去冰/薄冰" }
                );
                modelBuilder.Entity<TeasOriginalSug>().HasData(
                    new TeasOriginalSug { ID = "TeasOriginalSug001", SugarName = "正常糖" },
                    new TeasOriginalSug { ID = "TeasOriginalSug002", SugarName = "少糖" },
                    new TeasOriginalSug { ID = "TeasOriginalSug003", SugarName = "半糖" },
                    new TeasOriginalSug { ID = "TeasOriginalSug004", SugarName = "微糖" },
                    new TeasOriginalSug { ID = "TeasOriginalSug005", SugarName = "無糖" }
                );
                //阿舍烏龍茶//
                modelBuilder.Entity<AsherTea>().HasData(
                    new AsherTea { ID = "AsherTea001", Name = "茉香綠茶", Money = 25 },
                    new AsherTea { ID = "AsherTea002", Name = "阿薩姆紅茶", Money = 25 },
                    new AsherTea { ID = "AsherTea003", Name = "翠玉青茶", Money = 25 },
                    new AsherTea { ID = "AsherTea004", Name = "炭焙烏龍茶", Money = 25 },
                    new AsherTea { ID = "AsherTea005", Name = "普洱菊花茶", Money = 25 }
                );
                modelBuilder.Entity<AsherYakult>().HasData(
                    new AsherYakult { ID = "AsherYakult001", Name = "養樂多綠茶", Money = 40 },
                    new AsherYakult { ID = "AsherYakult002", Name = "養樂多冬瓜", Money = 40 },
                    new AsherYakult { ID = "AsherYakult003", Name = "養樂多鮮榨檸檬", Money = 40 },
                    new AsherYakult { ID = "AsherYakult004", Name = "養樂多莓果", Money = 40 }
                );
                modelBuilder.Entity<AsherSummerSmoothies>().HasData(
                    new AsherSummerSmoothies { ID = "AsherSummerSmoothies001", Name = "手工綠豆冰沙", Money = 40 },
                    new AsherSummerSmoothies { ID = "AsherSummerSmoothies002", Name = "手打紅豆冰沙", Money = 40 },
                    new AsherSummerSmoothies { ID = "AsherSummerSmoothies003", Name = "手打百香果沙", Money = 40 }
                );
                modelBuilder.Entity<AsherMilkCover>().HasData(
                    new AsherMilkCover { ID = "AsherMilkCover001", Name = "奶蓋紅茶", Money = 40 },
                    new AsherMilkCover { ID = "AsherMilkCover002", Name = "奶蓋綠茶", Money = 40 },
                    new AsherMilkCover { ID = "AsherMilkCover003", Name = "奶蓋冬瓜茶", Money = 40 }
                );
                modelBuilder.Entity<AsherMilk>().HasData(
                    new AsherMilk { ID = "AsherMilk001", Name = "薄荷奶茶", Money = 40 },
                    new AsherMilk { ID = "AsherMilk002", Name = "芋頭奶香", Money = 40 },
                    new AsherMilk { ID = "AsherMilk003", Name = "焦糖奶茶", Money = 40 },
                    new AsherMilk { ID = "AsherMilk004", Name = "北海道奶茶", Money = 40 },
                    new AsherMilk { ID = "AsherMilk005", Name = "杏仁奶香", Money = 40 },
                    new AsherMilk { ID = "AsherMilk006", Name = "阿華田", Money = 40 }
                );
                modelBuilder.Entity<AsherMatcha>().HasData(
                    new AsherMatcha { ID = "AsherMatcha001", Name = "抹茶奶香", Money = 45 },
                    new AsherMatcha { ID = "AsherMatcha002", Name = "抹茶紅豆", Money = 55 },
                    new AsherMatcha { ID = "AsherMatcha003", Name = "抹茶鮮奶", Money = 55 }
                );
                modelBuilder.Entity<AsherAncient>().HasData(
                    new AsherAncient { ID = "AsherAncient001", Name = "古早味冬瓜茶", Money = 25 },
                    new AsherAncient { ID = "AsherAncient002", Name = "古早味冬瓜青茶", Money = 25 },
                    new AsherAncient { ID = "AsherAncient003", Name = "古早味冬瓜珍珠", Money = 30 },
                    new AsherAncient { ID = "AsherAncient004", Name = "古早味冬瓜QQ", Money = 35 },
                    new AsherAncient { ID = "AsherAncient005", Name = "古早味冬瓜仙草", Money = 35 },
                    new AsherAncient { ID = "AsherAncient006", Name = "古早味冬瓜檸檬", Money = 40 },
                    new AsherAncient { ID = "AsherAncient007", Name = "古早味冬瓜鮮奶", Money = 40 }
                );
                modelBuilder.Entity<AsherChew>().HasData(
                    new AsherChew { ID = "AsherChew001", Name = "珍珠奶茶", Money = 35 },
                    new AsherChew { ID = "AsherChew002", Name = "椰果奶茶", Money = 35 },
                    new AsherChew { ID = "AsherChew003", Name = "百香綠QQ", Money = 40 },
                    new AsherChew { ID = "AsherChew004", Name = "QQ奶茶(珍珠+椰果)", Money = 40 },
                    new AsherChew { ID = "AsherChew005", Name = "仙草凍奶茶", Money = 40 },
                    new AsherChew { ID = "AsherChew006", Name = "咖啡凍奶茶", Money = 40 },
                    new AsherChew { ID = "AsherChew007", Name = "蜜紅豆奶茶", Money = 40 },
                    new AsherChew { ID = "AsherChew008", Name = "統一布丁奶茶", Money = 45 },
                    new AsherChew { ID = "AsherChew009", Name = "醇鮮奶仙草凍", Money = 45 }
                );
                modelBuilder.Entity<AsherFresh>().HasData(
                    new AsherFresh { ID = "AsherFresh001", Name = "純蜜茶", Money = 30 },
                    new AsherFresh { ID = "AsherFresh002", Name = "黃金柚子茶", Money = 40 },
                    new AsherFresh { ID = "AsherFresh003", Name = "招牌莓果茶", Money = 40 },
                    new AsherFresh { ID = "AsherFresh004", Name = "甘蔗青茶", Money = 40 },
                    new AsherFresh { ID = "AsherFresh005", Name = "鮮榨檸檬綠茶", Money = 40 },
                    new AsherFresh { ID = "AsherFresh006", Name = "鮮榨梅子檸檬汁", Money = 40 },
                    new AsherFresh { ID = "AsherFresh007", Name = "蜂蜜檸檬蘆薈", Money = 40 },
                    new AsherFresh { ID = "AsherFresh008", Name = "鮮榨蜂蜜檸檬汁", Money = 40 }
                );
                modelBuilder.Entity<AsherTaro>().HasData(
                    new AsherTaro { ID = "AsherTaro001", Name = "地芋冬瓜茶", Money = 35 },
                    new AsherTaro { ID = "AsherTaro002", Name = "地芋紅茶", Money = 35 },
                    new AsherTaro { ID = "AsherTaro003", Name = "地芋奶茶", Money = 40 }
                );
                modelBuilder.Entity<AsherMat>().HasData(
                    new AsherMat { ID = "AsherMat001", TeaMaterialName = "珍珠", Money = 5 },
                    new AsherMat { ID = "AsherMat002", TeaMaterialName = "椰果", Money = 5 },
                    new AsherMat { ID = "AsherMat003", TeaMaterialName = "蘆薈", Money = 5 },
                    new AsherMat { ID = "AsherMat004", TeaMaterialName = "紅豆", Money = 10 },
                    new AsherMat { ID = "AsherMat005", TeaMaterialName = "仙草", Money = 10 },
                    new AsherMat { ID = "AsherMat006", TeaMaterialName = "地芋", Money = 10 },
                    new AsherMat { ID = "AsherMat007", TeaMaterialName = "統一布丁", Money = 15 },
                    new AsherMat { ID = "AsherMat008", TeaMaterialName = "無", Money = 0 }
                );
                modelBuilder.Entity<AsherIce>().HasData(
                    new AsherIce { ID = "AsherIce001", IceName = "正常冰" },
                    new AsherIce { ID = "AsherIce002", IceName = "少冰" },
                    new AsherIce { ID = "AsherIce003", IceName = "微冰" },
                    new AsherIce { ID = "AsherIce004", IceName = "去冰" }
                );
                modelBuilder.Entity<AsherSug>().HasData(
                    new AsherSug { ID = "AsherSug001", SugarName = "全糖" },
                    new AsherSug { ID = "AsherSug002", SugarName = "少糖" },
                    new AsherSug { ID = "AsherSug003", SugarName = "半糖" },
                    new AsherSug { ID = "AsherSug004", SugarName = "微糖" },
                    new AsherSug { ID = "AsherSug006", SugarName = "無糖" }
                );
            }
        }
    }
}
