using Microsoft.AspNetCore.Mvc;

namespace L06_MVC1.Controllers;

public class CalculatorController : Controller
{
    [HttpGet]
    public ActionResult TimeCalculator()
    {
        return View();
    }

    [HttpPost]
    public ActionResult TimeCalculator(IFormCollection formCollection)
    {
        var hours = Convert.ToInt32(formCollection["Hours"]);
        var minutes = Convert.ToInt32(formCollection["Minutes"]);
        var seconds = Convert.ToInt32(formCollection["Seconds"]);

        var ts = new TimeSpan(0, hours, minutes, seconds);
        var total = ts.TotalSeconds;

        ViewBag.Hours = hours;
        ViewBag.Minutes = minutes;
        ViewBag.Seconds = seconds;
        ViewBag.Total = total;
        
        return View();
    }
}