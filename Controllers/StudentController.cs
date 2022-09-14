
using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models;
namespace BuiThiKimNganBTH.Controllers
{
    public class StudentController : Controller
    {
        

        [HttpPost]
        public IActionResult Index(Student std)
        {
            ViewBag.message = std.StudentID+"-"+std.StudentName+"-"+std.StudentAge   ;
            return View();
        }
        public IActionResult Index()
        {
            List<Student> stdList = new List<Student>()
          {
              new Student {StudentID =1, StudentName ="A", StudentAge=18},
              new Student {StudentID =2, StudentName ="B", StudentAge=19}, 
              new Student {StudentID =3, StudentName ="C", StudentAge=20},
              new Student {StudentID =4, StudentName ="D", StudentAge=21},
              new Student {StudentID =5, StudentName ="E", StudentAge=22}
          };
             ViewData["Students"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        public IActionResult Create (Student std)
        {
              string message  = std.StudentID + "-";
              message += std.StudentName + "-";
              message += std.StudentAge;
              ViewBag.ThongBao = message;
            return View();
        }
    }
}




