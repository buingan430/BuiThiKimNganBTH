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
    public IActionResult Create ()
    {
        return View();
    }
}