using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L07_HTML_helpers.Controllers;

public class Exercise03Controller : Controller
{
    private Dictionary<string, decimal> breakfastPricelist = new Dictionary<string, decimal>();
    
    public ActionResult Index()
    {
        var breakfastItems = new List<SelectListItem>
        {
            new SelectListItem("Cornflaskes", "Cornflakes"),
            new SelectListItem("Egg", "Egg"),
            new SelectListItem("Toast", "Toast"),
            new SelectListItem("Juice", "Juice"),
            new SelectListItem("Milk", "Milk"),
            new SelectListItem("Coffee", "Coffee"),
            new SelectListItem("Tea", "Tea")
        };

        ViewBag.BreakfastItems = breakfastItems;

        return View(breakfastItems);
    }

    [HttpPost]
    public ActionResult Index(IFormCollection formdata)
    {
        breakfastPricelist.Add("Cornflakes", 25.50m);
        breakfastPricelist.Add("Egg", 15.75m);
        breakfastPricelist.Add("Toast", 12.50m);
        breakfastPricelist.Add("Juice", 18.00m);
        breakfastPricelist.Add("Milk", 15.25m);
        breakfastPricelist.Add("Tea", 12.50m);
        breakfastPricelist.Add("Coffee", 16.00m);
        
        ViewBag.FullName = formdata["fullName"];
        ViewBag.RoomNumber = formdata["roomNumber"];
        ViewBag.Time = formdata["time"];

        string breakfastItems = formdata["breakfastItems"];
        var items = breakfastItems.Split(',').Where(s => !s.Equals("false")).ToArray();

        var selectedItems = new List<string>();

        var total = 0.00m;
        foreach (var i in items)
        {
            var price = breakfastPricelist[i];
            selectedItems.Add(i + " (" + price + ")");
            total += price;
        }

        ViewBag.TotalPrice = total;
        ViewBag.OrderedItems = string.Join(", ", selectedItems);
        
        return View("Reciept");
    }
}