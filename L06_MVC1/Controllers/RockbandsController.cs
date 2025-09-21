using Microsoft.AspNetCore.Mvc;

namespace L06_MVC1.Controllers;

public class RockbandsController : Controller
{
    public ActionResult Index()
    {
        // Array declaring and assigning
        string[] rockbands = [
            "Led Zeppelin", "The Beatles",
            "Pink Floyd", "The Jimi Hendrix Experience",
            "Van Halen", "Queen",
            "The Eagles", "Metallica",
            "U2", "Bob Marley and the Wailers"
        ];
        // Assign to ViewBag property
        ViewBag.rockbands = rockbands;
        
        return View();
    }
}