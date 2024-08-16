using ChatWithFriends.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ChatWithFriends.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Xml.Linq;
using ChatWithFriends.Models;
using Microsoft.EntityFrameworkCore;
using static ChatWithFriends.Data.DrinkJson;
using System.Threading.Tasks;

namespace ChatWithFriends.Controllers
{
    [Authorize]
    public class DrinkHomeController : Controller
    {
        private readonly DrinkJson.DrinkContext _context;
        private readonly SafeContext _safecontext;

        public DrinkHomeController(DrinkJson.DrinkContext context ,SafeContext safeContext)
        {
            _context = context;
            _safecontext = safeContext;
        }
        public IActionResult DrinkAll()
        {
            return View();
        }
        
        public async Task<IActionResult> ANiceholiday()
        {
            var ANiceholidayViewModel = new ANiceholidayViewModel
            {
                ANiOriginalTea = await _context.ANiOriginalTea.ToListAsync(),
                ANiflavoredTea = await _context.ANiflavoredTea.ToListAsync(),
                ANiTasteTea = await _context.ANiTasteTea.ToListAsync(),
                ANiMilkTea = await _context.ANiMilkTea.ToListAsync(),
                ANiCheeseMilkCap = await _context.ANiCheeseMilkCap.ToListAsync(),
                ANiFreshMilkTea = await _context.ANiFreshMilkTea.ToListAsync(),
                ANiWinterMelonTea = await _context.ANiWinterMelonTea.ToListAsync(),
                ANiceholidayMat = await _context.ANiceholidayMat.ToListAsync(),
                ANiceholidayIce = await _context.ANiceholidayIce.ToListAsync(),
                ANiceholidaySug = await _context.ANiceholidaySug.ToListAsync()
            };
            return View(ANiceholidayViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> ANiceholiday(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.ANiceholidayMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> Richtea()
        {
            var RichteaViewModel = new RichteaViewModel
            {
                RicThickMilkTea = await _context.RicThickMilkTea.ToListAsync(),
                RicSmallFarmerThickBreasts = await _context.RicSmallFarmerThickBreasts.ToListAsync(),
                RicPureThickTea = await _context.RicPureThickTea.ToListAsync(),
                RicFragrantMilkTea = await _context.RicFragrantMilkTea.ToListAsync(),
                RicRefreshingFruitTea = await _context.RicRefreshingFruitTea.ToListAsync(),
                RicChewySeries = await _context.RicChewySeries.ToListAsync(),
                RicRoyalGradeSpecialBlend = await _context.RicRoyalGradeSpecialBlend.ToListAsync(),
                RicMilkCapSpecialBlend = await _context.RicMilkCapSpecialBlend.ToListAsync(),
                RichteaMat = await _context.RichteaMat.ToListAsync(),
                RichteaIce = await _context.RichteaIce.ToListAsync(),
                RichteaSug = await _context.RichteaSug.ToListAsync()
            };
            return View(RichteaViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Richtea(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.RichteaMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> BallsTea()
        {
            var BallsTeaviewModel = new BallsTeaViewModel
            {
                BalTea = await _context.BalTea.ToListAsync(),
                BalFreshmilktea = await _context.BalFreshmilktea.ToListAsync(),
                BalHandpath = await _context.BalHandpath.ToListAsync(),
                BalSnowfungus = await _context.BalSnowfungus.ToListAsync(),
                BalMilktea = await _context.BalMilktea.ToListAsync(),
                BalMilk = await _context.BalMilk.ToListAsync(),
                BalCloudcover = await _context.BalCloudcover.ToListAsync(),
                BalThickslices = await _context.BalThickslices.ToListAsync(),
                BalFruity = await _context.BalFruity.ToListAsync(),
                BalSpecialblend = await _context.BalSpecialblend.ToListAsync(),
                BalWinterlimited = await _context.BalWinterlimited.ToListAsync(),
                BallsTeaMat = await _context.BallsTeaMat.ToListAsync(),
                BallsTeaIce = await _context.BallsTeaIce.ToListAsync(),
                BallsTeaSug = await _context.BallsTeaSug.ToListAsync(),
            };
            return View(BallsTeaviewModel);
        }


        [HttpPost]
        public async Task<IActionResult> BallsTea(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.BallsTeaMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> FiftyLan()
        {
            var FiftyLanviewModel = new FiftyLanViewModel
            {
                FiftyLanTea = await _context.FiftyLanTea.ToListAsync(),
                FiftyLanLatte = await _context.FiftyLanLatte.ToListAsync(),
                FiftyLanFresh = await _context.FiftyLanFresh.ToListAsync(),
                FiftyLanSeasonal = await _context.FiftyLanSeasonal.ToListAsync(),
                FiftyLanMat = await _context.FiftyLanMat.ToListAsync(),
                FiftyLanIce = await _context.FiftyLanIce.ToListAsync(),
                FiftyLanSug = await _context.FiftyLanSug.ToListAsync(),
            };
            return View(FiftyLanviewModel);
        }


        [HttpPost]
        public async Task<IActionResult> FiftyLan(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.FiftyLanMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }

        public async Task<IActionResult> LIKEFANG()
        {
            var LIKEFANGviewModel = new LIKEFANGViewModel
            {
                LIKEFANGThickMilkCover = await _context.LIKEFANGThickMilkCover.ToListAsync(),
                LIKEFANGFreshMilkTea = await _context.LIKEFANGFreshMilkTea.ToListAsync(),
                LIKEFANGBrownSugar = await _context.LIKEFANGBrownSugar.ToListAsync(),
                LIKEFANGFreshFruit = await _context.LIKEFANGFreshFruit.ToListAsync(),
                LIKEFANGSpecialBlend = await _context.LIKEFANGSpecialBlend.ToListAsync(),
                LIKEFANGKitKat = await _context.LIKEFANGKitKat.ToListAsync(),
                LIKEFANGMilkTea = await _context.LIKEFANGMilkTea.ToListAsync(),
                LIKEFANGTea = await _context.LIKEFANGTea.ToListAsync(),
                LIKEFANGMat = await _context.LIKEFANGMat.ToListAsync(),
                LIKEFANGIce = await _context.LIKEFANGIce.ToListAsync(),
                LIKEFANGSug = await _context.LIKEFANGSug.ToListAsync(),
            };
            return View(LIKEFANGviewModel);
        }


        [HttpPost]
        public async Task<IActionResult> LIKEFANG(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.LIKEFANGMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }

        public async Task<IActionResult> COMEBUY()
        {
            var COMEBUYviewModel = new COMEBUYViewModel
            {
                COMEBUYOriginalLeaves = await _context.COMEBUYOriginalLeaves.ToListAsync(),
                COMEBUYFreshTeaLatte = await _context.COMEBUYFreshTeaLatte.ToListAsync(),
                COMEBUYFreshFruitTea = await _context.COMEBUYFreshFruitTea.ToListAsync(),
                COMEBUYReally = await _context.COMEBUYReally.ToListAsync(),
                COMEBUYSummerOnly = await _context.COMEBUYSummerOnly.ToListAsync(),
                COMEBUYMilkTeaCocoa = await _context.COMEBUYMilkTeaCocoa.ToListAsync(),
                COMEBUYSpecialCoffee = await _context.COMEBUYSpecialCoffee.ToListAsync(),
                COMEBUYWinterOnly = await _context.COMEBUYWinterOnly.ToListAsync(),
                COMEBUYMat = await _context.COMEBUYMat.ToListAsync(),
                COMEBUYIce = await _context.COMEBUYIce.ToListAsync(),
                COMEBUYSug = await _context.COMEBUYSug.ToListAsync(),
            };
            return View(COMEBUYviewModel);
        }


        [HttpPost]
        public async Task<IActionResult> COMEBUY(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.COMEBUYMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> JinchaWu()
        {
            var JinchaWuviewModel = new JinchaWuViewModel
            {
                JinchaWuQKueh = await _context.JinchaWuQKueh.ToListAsync(),
                JinchaWuGoldenGoodTea = await _context.JinchaWuGoldenGoodTea.ToListAsync(),
                JinchaWuGoldenFresh = await _context.JinchaWuGoldenFresh.ToListAsync(),
                JinchaWuKimHougong = await _context.JinchaWuKimHougong.ToListAsync(),
                JinchaWuJinHaomian = await _context.JinchaWuJinHaomian.ToListAsync(),
                JinchaWuJinYoumi = await _context.JinchaWuJinYoumi.ToListAsync(),
                JinchaWuMat = await _context.JinchaWuMat.ToListAsync(),
                JinchaWuIce = await _context.JinchaWuIce.ToListAsync(),
                JinchaWuSug = await _context.JinchaWuSug.ToListAsync(),
            };
            return View(JinchaWuviewModel);
        }


        [HttpPost]
        public async Task<IActionResult> JinchaWu(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.JinchaWuMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> MakeYourOwnBlackTeaMilk()
        {
            var MakeYourOwnBlackTeaMilkViewModel = new MakeYourOwnBlackTeaMilkViewModel
            {
                MakeYourOwnBlackTeaMilkFreshMilkTea = await _context.MakeYourOwnBlackTeaMilkFreshMilkTea.ToListAsync(),
                MakeYourOwnBlackTeaMilkbreasts = await _context.MakeYourOwnBlackTeaMilkbreasts.ToListAsync(),
                MakeYourOwnBlackTeaMilkFreshSheep = await _context.MakeYourOwnBlackTeaMilkFreshSheep.ToListAsync(),
                MakeYourOwnBlackTeaMilkGoodTea = await _context.MakeYourOwnBlackTeaMilkGoodTea.ToListAsync(),
                MakeYourOwnBlackTeaMilkCheeseMilkCap = await _context.MakeYourOwnBlackTeaMilkCheeseMilkCap.ToListAsync(),
                MakeYourOwnBlackTeaMilkFreshlySqueezed = await _context.MakeYourOwnBlackTeaMilkFreshlySqueezed.ToListAsync(),
                MakeYourOwnBlackTeaMilkSoyMilk = await _context.MakeYourOwnBlackTeaMilkSoyMilk.ToListAsync(),
                MakeYourOwnBlackTeaMilkMat = await _context.MakeYourOwnBlackTeaMilkMat.ToListAsync(),
                MakeYourOwnBlackTeaMilkIce = await _context.MakeYourOwnBlackTeaMilkIce.ToListAsync(),
                MakeYourOwnBlackTeaMilkSug = await _context.MakeYourOwnBlackTeaMilkSug.ToListAsync(),
            };
            return View(MakeYourOwnBlackTeaMilkViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> MakeYourOwnBlackTeaMilk(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.MakeYourOwnBlackTeaMilkMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> WongKeeTeaHouse()
        {
            var WongKeeTeaHouseviewModel = new WongKeeTeaHouseViewModel
            {
                WongKeeTeaHouseTea = await _context.WongKeeTeaHouseTea.ToListAsync(),
                WongKeeTeaHouseSpecialBlend = await _context.WongKeeTeaHouseSpecialBlend.ToListAsync(),
                WongKeeTeaHouseMat = await _context.WongKeeTeaHouseMat.ToListAsync(),
                WongKeeTeaHouseIce = await _context.WongKeeTeaHouseIce.ToListAsync(),
                WongKeeTeaHouseSug = await _context.WongKeeTeaHouseSug.ToListAsync(),
            };
            return View(WongKeeTeaHouseviewModel);
        }


        [HttpPost]
        public async Task<IActionResult> WongKeeTeaHouse(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.WongKeeTeaHouseMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }

        public async Task<IActionResult> DedeTea()
        {
            var DedeTeaViewModel = new DedeTeaViewModel
            {
                DedeTeaRoyalchoiceitem = await _context.DedeTeaRoyalchoiceitem.ToListAsync(),
                DedeTeaPrincessofFlowers = await _context.DedeTeaPrincessofFlowers.ToListAsync(),
                DedeTeaRoyalLatte = await _context.DedeTeaRoyalLatte.ToListAsync(),
                DedeTeaRoyalFragrantMilkTea = await _context.DedeTeaRoyalFragrantMilkTea.ToListAsync(),
                DedeTeaClassicSpecialties = await _context.DedeTeaClassicSpecialties.ToListAsync(),
                DedeTeaMat = await _context.DedeTeaMat.ToListAsync(),
                DedeTeaIce = await _context.DedeTeaIce.ToListAsync(),
                DedeTeaSug = await _context.DedeTeaSug.ToListAsync(),
            };
            return View(DedeTeaViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> DedeTea(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.DedeTeaMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> CHAGE()
        {
            var CHAGEViewModel = new CHAGEViewModel
            {
                CHAGESpecialBlend = await _context.CHAGESpecialBlend.ToListAsync(),
                CHAGEMilk = await _context.CHAGEMilk.ToListAsync(),
                CHAGETea = await _context.CHAGETea.ToListAsync(),
                CHAGEScentedTea = await _context.CHAGEScentedTea.ToListAsync(),
                CHAGEMilkTea = await _context.CHAGEMilkTea.ToListAsync(),
                CHAGETeaGoodMat = await _context.CHAGETeaGoodMat.ToListAsync(),
                CHAGESeasonal = await _context.CHAGESeasonal.ToListAsync(),
                CHAGENaigai = await _context.CHAGENaigai.ToListAsync(),
                CHAGEMat = await _context.CHAGEMat.ToListAsync(),
                CHAGEIce = await _context.CHAGEIce.ToListAsync(),
                CHAGESug = await _context.CHAGESug.ToListAsync(),
            };
            return View(CHAGEViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> CHAGE(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.CHAGEMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> DaMingJadeDew()
        {
            var DaMingJadeDewViewModel = new DaMingJadeDewViewModel
            {
                DaMingJadeDewClassic = await _context.DaMingJadeDewClassic.ToListAsync(),
                DaMingJadeDewOriginalTea = await _context.DaMingJadeDewOriginalTea.ToListAsync(),
                DaMingJadeDewLatte = await _context.DaMingJadeDewLatte.ToListAsync(),
                DaMingJadeDewMilkTea = await _context.DaMingJadeDewMilkTea.ToListAsync(),
                DaMingJadeDewNaigai = await _context.DaMingJadeDewNaigai.ToListAsync(),
                DaMingJadeDewWinterOnly = await _context.DaMingJadeDewWinterOnly.ToListAsync(),
                DaMingJadeDewFreshFruit = await _context.DaMingJadeDewFreshFruit.ToListAsync(),
                DaMingJadeDewMat = await _context.DaMingJadeDewMat.ToListAsync(),
                DaMingJadeDewIce = await _context.DaMingJadeDewIce.ToListAsync(),
                DaMingJadeDewSug = await _context.DaMingJadeDewSug.ToListAsync(),
            };
            return View(DaMingJadeDewViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> DaMingJadeDew(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.DaMingJadeDewMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> ShangYulin()
        {
            var ShangYulinViewModel = new ShangYulinViewModel
            {
                ShangYulinTop = await _context.ShangYulinTop.ToListAsync(),
                ShangYulinRich = await _context.ShangYulinRich.ToListAsync(),
                ShangYulinMilk = await _context.ShangYulinMilk.ToListAsync(),
                ShangYulinTea = await _context.ShangYulinTea.ToListAsync(),
                ShangYulinHealth = await _context.ShangYulinHealth.ToListAsync(),
                ShangYulinMountain = await _context.ShangYulinMountain.ToListAsync(),
                ShangYulinMat = await _context.ShangYulinMat.ToListAsync(),
                ShangYulinIce = await _context.ShangYulinIce.ToListAsync(),
                ShangYulinSug = await _context.ShangYulinSug.ToListAsync()
            };
            return View(ShangYulinViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> ShangYulin(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.ShangYulinMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> Wanbo()
        {
            var WanboViewModel = new WanboViewModel
            {
                WanboFeatured = await _context.WanboFeatured.ToListAsync(),
                WanboHandPath = await _context.WanboHandPath.ToListAsync(),
                WanboMilk = await _context.WanboMilk.ToListAsync(),
                WanboOld = await _context.WanboOld.ToListAsync(),
                WanboMilKTea = await _context.WanboMilKTea.ToListAsync(),
                WanboFruit = await _context.WanboFruit.ToListAsync(),
                WanboWinter = await _context.WanboWinter.ToListAsync(),
                WanboMat = await _context.WanboMat.ToListAsync(),
                WanboIce = await _context.WanboIce.ToListAsync(),
                WanboSug = await _context.WanboSug.ToListAsync()
            };
            return View(WanboViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Wanbo(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.WanboMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }

        public async Task<IActionResult> MrQueen()
        {
            var MrQueenViewModel = new MrQueenViewModel
            {
                MrQueenTea = await _context.MrQueenTea.ToListAsync(),
                MrQueenMilk = await _context.MrQueenMilk.ToListAsync(),
                MrQueenCoffee = await _context.MrQueenCoffee.ToListAsync(),
                MrQueenTallMilk = await _context.MrQueenTallMilk.ToListAsync(),
                MrQueenFive = await _context.MrQueenFive.ToListAsync(),
                MrQueenMat = await _context.MrQueenMat.ToListAsync(),
                MrQueenIce = await _context.MrQueenIce.ToListAsync(),
                MrQueenSug = await _context.MrQueenSug.ToListAsync()
            };
            return View(MrQueenViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> MrQueen(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.MrQueenMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> RestingPavilion()
        {
            var RestingPavilionViewModel = new RestingPavilionViewModel
            {
                RestingPavilionFruit = await _context.RestingPavilionFruit.ToListAsync(),
                RestingPavilionMilk = await _context.RestingPavilionMilk.ToListAsync(),
                RestingPavilionTaiwan = await _context.RestingPavilionTaiwan.ToListAsync(),
                RestingPavilionLatte = await _context.RestingPavilionLatte.ToListAsync(),
                RestingPavilionRemember = await _context.RestingPavilionRemember.ToListAsync(),
                RestingPavilionMilkCheese = await _context.RestingPavilionMilkCheese.ToListAsync(),
                RestingPavilionGlobal = await _context.RestingPavilionGlobal.ToListAsync(),
                RestingPavilionMat = await _context.RestingPavilionMat.ToListAsync(),
                RestingPavilionIce = await _context.RestingPavilionIce.ToListAsync(),
                RestingPavilionSug = await _context.RestingPavilionSug.ToListAsync()
            };
            return View(RestingPavilionViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> RestingPavilion(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.RestingPavilionMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> SunriseTea()
        {
            var SunriseTeaViewModel = new SunriseTeaViewModel
            {
                SunriseTeaThickTeaLatte = await _context.SunriseTeaThickTeaLatte.ToListAsync(),
                SunriseTeaTeaLatte = await _context.SunriseTeaTeaLatte.ToListAsync(),
                SunriseTeaFresh = await _context.SunriseTeaFresh.ToListAsync(),
                SunriseTeaMilk = await _context.SunriseTeaMilk.ToListAsync(),
                SunriseTeaHealthy = await _context.SunriseTeaHealthy.ToListAsync(),
                SunriseTeaCorridor = await _context.SunriseTeaCorridor.ToListAsync(),
                SunriseTeaMat = await _context.SunriseTeaMat.ToListAsync(),
                SunriseTeaIce = await _context.SunriseTeaIce.ToListAsync(),
                SunriseTeaSug = await _context.SunriseTeaSug.ToListAsync()
            };
            return View(SunriseTeaViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> SunriseTea(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.SunriseTeaMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> Lai()
        {
            var LaiViewModel = new LaiViewModel
            {
                LaiTeaBag = await _context.LaiTeaBag.ToListAsync(),
                LaiFacia = await _context.LaiFacia.ToListAsync(),
                LaiTea = await _context.LaiTea.ToListAsync(),
                LaiMilkTea = await _context.LaiMilkTea.ToListAsync(),
                LaiAncient = await _context.LaiAncient.ToListAsync(),
                LaiOolong = await _context.LaiOolong.ToListAsync(),
                LaiWinterMelon = await _context.LaiWinterMelon.ToListAsync(),
                LaiQueen = await _context.LaiQueen.ToListAsync(),
                LaiTune = await _context.LaiTune.ToListAsync(),
                LaiSesame = await _context.LaiSesame.ToListAsync(),
                LaiMat = await _context.LaiMat.ToListAsync(),
                LaiIce = await _context.LaiIce.ToListAsync(),
                LaiSug = await _context.LaiSug.ToListAsync(),
            };
            return View(LaiViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Lai(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.LaiMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }

        public async Task<IActionResult> WulinTea()
        {
            var WulinTeaViewModel = new WulinTeaViewModel
            {
                WulinSoul = await _context.WulinSoul.ToListAsync(),
                WulinSpecialBlend = await _context.WulinSpecialBlend.ToListAsync(),
                WulinFifty = await _context.WulinFifty.ToListAsync(),
                WulinMaterial = await _context.WulinMaterial.ToListAsync(),
                WulinFruit = await _context.WulinFruit.ToListAsync(),
                WulinMilkTea = await _context.WulinMilkTea.ToListAsync(),
                WulinPurple = await _context.WulinPurple.ToListAsync(),
                WulinMat = await _context.WulinMat.ToListAsync(),
                WulinIce = await _context.WulinIce.ToListAsync(),
                WulinSug = await _context.WulinSug.ToListAsync()
            };
            return View(WulinTeaViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> WulinTea(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.WulinMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }
        public async Task<IActionResult> TeasOriginal()
        {
            var TeasOriginalViewModel = new TeasOriginalViewModel
            {
                TeasOriginalTea = await _context.TeasOriginalTea.ToListAsync(),
                TeasOriginalChew = await _context.TeasOriginalChew.ToListAsync(),
                TeasOriginalMilkAroma = await _context.TeasOriginalMilkAroma.ToListAsync(),
                TeasOriginalFruit = await _context.TeasOriginalFruit.ToListAsync(),
                TeasOriginalSpecialBlend = await _context.TeasOriginalSpecialBlend.ToListAsync(),
                TeasOriginalJapan = await _context.TeasOriginalJapan.ToListAsync(),
                TeasOriginalMilk = await _context.TeasOriginalMilk.ToListAsync(),
                TeasOriginalHot = await _context.TeasOriginalHot.ToListAsync(),
                TeasOriginalMat = await _context.TeasOriginalMat.ToListAsync(),
                TeasOriginalIce = await _context.TeasOriginalIce.ToListAsync(),
                TeasOriginalSug = await _context.TeasOriginalSug.ToListAsync(),
            };
            return View(TeasOriginalViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> TeasOriginal(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money, string Money1, string Money2)
        {
            int cups;
            int money, money1, money2;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!int.TryParse(Money1, out money1))
            {
                ModelState.AddModelError("Money1", "無效金額");
                money1 = 0;
            }

            if (!int.TryParse(Money2, out money2))
            {
                ModelState.AddModelError("Money2", "無效金額");
                money2 = 0;
            }

            string teaMaterialPrice = "";
            int teaMaterialprice = 0;

            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.TeasOriginalMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            teaMaterialPrice = teaMaterialprice.ToString();

            int totals = money + money1 + money2 + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;

            string selectedPrice = "";
            if (!string.IsNullOrEmpty(Money))
            {
                selectedPrice = Money;
            }
            else if (!string.IsNullOrEmpty(Money1))
            {
                selectedPrice = Money1;
            }
            else if (!string.IsNullOrEmpty(Money2))
            {
                selectedPrice = Money2;
            }
            TempData["SelectedPrice"] = selectedPrice;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money,
                Money1 = Money1,
                Money2 = Money2
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }

        public async Task<IActionResult> Asher()
        {
            var AsherViewModel = new AsherViewModel
            {
                AsherTea = await _context.AsherTea.ToListAsync(),
                AsherYakult = await _context.AsherYakult.ToListAsync(),
                AsherSummerSmoothies = await _context.AsherSummerSmoothies.ToListAsync(),
                AsherMilkCover = await _context.AsherMilkCover.ToListAsync(),
                AsherMilk = await _context.AsherMilk.ToListAsync(),
                AsherMatcha = await _context.AsherMatcha.ToListAsync(),
                AsherAncient = await _context.AsherAncient.ToListAsync(),
                AsherChew = await _context.AsherChew.ToListAsync(),
                AsherFresh = await _context.AsherFresh.ToListAsync(),
                AsherTaro = await _context.AsherTaro.ToListAsync(),
                AsherMat = await _context.AsherMat.ToListAsync(),
                AsherIce = await _context.AsherIce.ToListAsync(),
                AsherSug = await _context.AsherSug.ToListAsync()
            };
            return View(AsherViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Asher(string shop, string ordername, string cupCount, string[] name, string[] teaMaterialName, string IceName, string SugarName, string Money)
        {
            int cups;
            int money;

            if (!int.TryParse(cupCount, out cups))
            {
                ModelState.AddModelError("cupCount", "請輸入有效的杯數");
            }

            if (!int.TryParse(Money, out money))
            {
                ModelState.AddModelError("Money", "無效金額");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            int teaMaterialprice = 0;
            foreach (var material in teaMaterialName)
            {
                var teaMaterial = await _context.AsherMat.FirstOrDefaultAsync(t => t.TeaMaterialName == material);
                int materialPrice = 0;

                if (teaMaterial != null)
                {
                    if (int.TryParse(teaMaterial.Money.ToString(), out int tempPrice))
                    {
                        materialPrice = tempPrice;
                    }
                }

                teaMaterialprice += materialPrice;
            }

            int totals = money + teaMaterialprice;

            TempData["Shop"] = shop;
            TempData["OrderName"] = ordername;
            TempData["CupCount"] = cups;
            TempData["Names"] = name;
            TempData["TeaMaterials"] = teaMaterialName;
            TempData["Ice"] = IceName;
            TempData["Sugar"] = SugarName;
            TempData["Total"] = totals;
            TempData["SelectedPrice"] = Money;

            var safe = new Safe
            {
                Total = totals.ToString(),
                Shop = shop,
                OrderName = ordername,
                CupCount = cups,
                Name = string.Join(",", name),
                TeaMaterialName = string.Join(",", teaMaterialName),
                IceName = IceName,
                SugarName = SugarName,
                OrderTime = DateTime.Now,
                Money = Money
            };

            _safecontext.Safes.Add(safe);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction("ShopCar", "DrinkHome");
        }







































        public IActionResult ShopCar()
        {
            int cupCount = (int)TempData["CupCount"];
            string[] name = TempData["Names"] as string[];
            string ordername = TempData["OrderName"] as string;
            string shop = TempData["Shop"] as string;
            string[] teaMaterials = TempData["TeaMaterials"] as string[];
            string ice = TempData["Ice"] as string;
            string sugar = TempData["Sugar"] as string;
            string selectedPrice = TempData["SelectedPrice"] as string;
            int totals = (int)TempData["Total"];

            ViewBag.SelectedPrice = selectedPrice;

            ViewBag.CupCount = cupCount;
            ViewBag.Name = name;
            ViewBag.OrderName = ordername;
            ViewBag.ShopCar = shop;
            ViewBag.TeaMaterials = teaMaterials;
            ViewBag.Ice = ice;
            ViewBag.Sugar = sugar;
            ViewBag.Total = totals;
            ViewBag.OrderTime = DateTime.Now;

            return View();
        }
        public async Task<IActionResult> DrinkDetail(DateTime orderTime)
        {
            var drink = await _safecontext.Safes
                .FirstOrDefaultAsync(m => m.OrderTime == orderTime);

            if (drink == null)
            {
                return NotFound(new { error = "找不到對應的飲料記錄!" });
            }

            return View(drink);
        }

        public async Task<IActionResult> DrinkDelete(DateTime orderTime)
        {
            var drink = await _safecontext.Safes
                .FirstOrDefaultAsync(m => m.OrderTime == orderTime);

            if (drink == null)
            {
                return NotFound(new { error = "找不到對應的飲料記錄!" });
            }

            return View(drink);
        }

        [HttpPost, ActionName("DrinkDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DrinkDeleteConfirmed(DateTime orderTime)
        {
            var drink = await _safecontext.Safes
                .FirstOrDefaultAsync(m => m.OrderTime == orderTime);

            if (drink == null)
            {
                return NotFound(new { error = "找不到對應的飲料記錄!" });
            }

            _safecontext.Safes.Remove(drink);
            await _safecontext.SaveChangesAsync();

            return RedirectToAction(nameof(Record));
        }



        public async Task<IActionResult> Record(DateTime OrderTime)
        {
            var ordersByDate = (await _safecontext.Safes
                .Where(m => m.OrderTime.Date >= OrderTime.Date)
                .ToListAsync())
                .GroupBy(m => m.OrderTime.Date)
                .OrderByDescending(g => g.Key)
                .ToList();

            return View(ordersByDate);
        }


    }
}
