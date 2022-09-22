using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models.Process;

namespace BuiThiKimNganBTH.Controllers
{
    public class DemoMVCController : Controller
    {
        // tạo các action thực thi các nhiệm vụ
        public IActionResult Index()
        {
            return View();
        }
        Giaiphuongtrinh gpt = new Giaiphuongtrinh();
        [HttpPost]
        public IActionResult Index(string hesoA, string hesoB )
        {
            double a = Convert.ToDouble(hesoA);
            double b = Convert.ToDouble(hesoB);
            string thongbao = gpt.GiaiphuongtrinhBacNhat(a,b);
            ViewBag.mess = thongbao;
            return View();
        }
        // phương trình bậc 2
        public IActionResult Creat()
        {
            return View();
        }
        
         
         public IActionResult Index2 (string hesoA, string hesoB, string hesoC)
         {
            double A = Convert.ToDouble(hesoA);
            double B = Convert.ToDouble(hesoB);
            double C = Convert.ToDouble(hesoC);
            string TB = gpt.GiaiphuongtrinhBacHai(A,B,C);
            ViewBag.thongbao = TB;
            return View(); 
         }
    }
}
