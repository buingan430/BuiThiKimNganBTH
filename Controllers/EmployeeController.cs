using Microsoft.AspNetCore.Mvc;
using BuiThiKimNganBTH.Models;
using PTPMQL.Models;

namespace NuiThiKimNgan.Controllers
{
    public class EmployeeController : Controller
    {
     
        public IActionResult Index( Employee std)
        {
            ViewBag.Ep = std.EmployeeID +"-"+ std.EmployeeName +"-"+ std.EmployeeAge;
       
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
    
}