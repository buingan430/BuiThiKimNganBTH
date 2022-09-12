using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models;
namespace BuiThiKimNganBTH.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
        /// List<Student> stdList = new List<Student>();
         //   {
          //      new Student {StudentID = 1, StudentName = "A", StudentAge = 18};
         //       new Student {StudentID = 1, StudentName = "A", StudentAge = 18};
         //       new Student {StudentID = 1, StudentName = "A", StudentAge = 18};
         //       new Student {StudentID = 1, StudentName = "A", StudentAge = 18};
         //       new Student {StudentID = 1, StudentName = "A", StudentAge = 18};
         //       new Student {StudentID = 1, StudentName = "A", StudentAge = 18};
         //   };
         //   ViewData["Students"] = stdList;
            return View();
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




