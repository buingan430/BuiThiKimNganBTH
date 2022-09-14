using Microsoft.AspNetCore.Mvc;
using BuiThiKimNganBTH.Models;
using PTPMQL.Models;

namespace BuiThiKimNgan.Controllers
{
    public class EmployeeController : Controller
    {
     
        public IActionResult Index( Employee std)
        {
            ViewBag.Ep = std.EmployeeID +"-"+ std.EmployeeName +"-"+ std.EmployeeAge;
       
            return View();
        }
        public IActionResult DS()
        {
            List<Employee> stdList = new List<Employee>()
          {
              new Employee {EmployeeID =1, EmployeeName ="A", EmployeeAge=18},
              new Employee {EmployeeID =2, EmployeeName ="B", EmployeeAge=19}, 
              new Employee {EmployeeID =3, EmployeeName ="C", EmployeeAge=20},
              new Employee {EmployeeID =4, EmployeeName ="D", EmployeeAge=21},
              new Employee {EmployeeID =5, EmployeeName ="E", EmployeeAge=22}
          };
             ViewData["Employees"] = stdList;
            return View(stdList);
        }
        [HttpPost]
        public IActionResult Create (Employee std)
        {
              string message  = std.EmployeeID + "-";
              message += std.EmployeeName + "-";
              message += std.EmployeeAge;
              ViewBag.ThongBao = message;
            return View();
        }
    }
    
}