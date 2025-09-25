using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using L08_Layouts_PartialViews_ViewComponents.Models;

namespace L08_Layouts_PartialViews_ViewComponents.Controllers;

public class HomeController : Controller
{
    public ActionResult Sale()
    {
        return View();
    }

    public ActionResult MoreSales()
    {
        return View();
    }

    public ActionResult Buy()
    {
        return View();
    }

    public ActionResult BuyAndSell()
    {
        return View();
    }
}