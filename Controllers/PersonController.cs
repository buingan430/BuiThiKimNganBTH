using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models;
namespace BuiThiKimNganBTH.Controllers;
public class PersonController: Controller
{
   
    public IActionResult Index(Person std)
    {
        ViewBag.Ps = std.PersonID + "-"+ std.PersonName + "-" + std.PersonAge; 
        return View();
    }
    public IActionResult DS ()
    {
        List<Person> stdList = new List<Person>()
        {
              new Person {PersonID =1, PersonName ="A", PersonAge=18},
              new Person {PersonID =2, PersonName ="B", PersonAge=19}, 
              new Person {PersonID =3, PersonName ="C", PersonAge=20},
              new Person {PersonID =4, PersonName ="D", PersonAge=21},
              new Person {PersonID =5, PersonName ="E", PersonAge=22} 
        };
        ViewData["Persons"] = stdList;
        return View(stdList);
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
             string message  = std.PersonID + "-";
              message += std.PersonName + "-";
              message += std.PersonAge + "-";
              ViewBag.ThongBao = message;
            return View();
    }
}