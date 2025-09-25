using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using L08_PartialView_ViewComponent.Models;

namespace L08_PartialView_ViewComponent.Controllers;

public class HomeController : Controller
{
    public ActionResult VisAlle()
    {
        return View(AllePersoner());
    }

    public ActionResult VisEn()
    {
        return View(AllePersoner()[0]);
    }
    
    // --------------- Helper methods ---------------
    private List<Person> AllePersoner()
    {
        List<Person> personer =
        [
            new Person("Søren", "Ibsen"),
            new Person("Ib", "Sørensen"),
            new Person("Hans", "Jensen"),
            new Person("Jens", "Hansen")
        ];

        return personer;
    }
}