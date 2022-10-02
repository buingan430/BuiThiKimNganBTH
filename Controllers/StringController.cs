using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models.Process;
namespace BuiThiKimNganBTH.Controllers
{
    public class StringController : Controller
    {
        public IActionResult Creat()
        {
            return View();
        }
        StringProcess Str = new StringProcess();
        [HttpPost]
        public IActionResult Creat(string strInput)
        {
            string TB = Str.RemoveRemainingWhiteSpace(strInput);
            ViewBag.Thongbao = TB;
            return View();
        }
        // in hoa
         public IActionResult T2()
        {
            return View();
        }
        [HttpPost]
         public IActionResult T2(string strInput)
         {
            string thongBao = Str.LowerToUpper(strInput);
            ViewBag.tb = thongBao;
            return View();
         }
         // in thường
         public IActionResult T3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult T3(string strInput)
         {
            string Hienthi = Str.UpperToLower(strInput);
            ViewBag.ht = Hienthi;
            return View();
         }
         // viết hoa chữ cái đầu
          public IActionResult T4()
        {
            return View();
        }
        [HttpPost]
        public IActionResult T4(string strInput)
         {
            string hienthi = Str.CapitalizeOneFirstCharacter(strInput);
            ViewBag.Ht = hienthi;
            return View();
         }
         // viết hoa tất cả các chữ cái đầu
         public IActionResult T5()
        {
            return View();
        }
        [HttpPost]
        public IActionResult T5(string strInput)
         {
            string hienthi = Str.CapitalizeFirstCharacter(strInput);
            ViewBag.HT = hienthi;
            return View();
         }
         
         //
          public IActionResult T6()
        {
            return View();
        }
        [HttpPost]
        public IActionResult T6(string strInput)
         {
            string hienthi = Str.RemoveVietnameseAccents(strInput);
            ViewBag.HienThi = hienthi;
            return View();
         }
    }

}