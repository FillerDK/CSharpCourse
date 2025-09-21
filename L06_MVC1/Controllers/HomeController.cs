using L06_MVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_MVC1.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        // Declaring variables
        string name;
        int age;
        DateTime birthday;
        // Assigning values
        name = "Philip";
        age = 23;
        birthday = new DateTime(2002, 05, 07);
        // Declaring ViewBag properties and asigning values
        ViewBag.name = name;
        ViewBag.age = age;
        ViewBag.birthday = birthday;
        
        return View(new HomeModel(name, age, birthday));
    }
}