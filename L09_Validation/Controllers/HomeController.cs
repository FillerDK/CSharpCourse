using Microsoft.AspNetCore.Mvc;
using L09_Validation.Models;

namespace L09_Validation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(Shoe shoe)
    {
        if (!ModelState.IsValid) return View(shoe);
        
        ModelState.Clear();
        return View(new Shoe());
    }
}