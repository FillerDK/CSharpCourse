using L07_HTML_helpers.Models.Exercise02;
using Microsoft.AspNetCore.Mvc;

namespace L07_HTML_helpers.Controllers;

public class Exercise02Controller: Controller
{
    public ActionResult Index()
    {
        var ptm = new ParkingTicketMachine();
        ViewBag.Payback = false;
        return View(ptm);
    }

    private string GetFormData(IFormCollection formdata, string key)
    {
        return formdata[key].Count > 0 ? formdata[key][0] : null;
    }
    
    [HttpPost]
    public ActionResult Index(IFormCollection formData) {
        
        // create a new instance of ParkingTicketMachine
        var ptm = new ParkingTicketMachine();
        
        // declare a variable of type int which keeps track of the amount inserted
        int AmountInserted;
        ViewBag.Payback = false;
        ViewBag.PaybackAmount = 0;
        
        // if the form field representing the amount is not null
        if (GetFormData(formData, "AmountInserted") != null)
        {
            // read the value the amount inserted and assign it to AmountInserted
            AmountInserted = Convert.ToInt16(GetFormData(formData, "AmountInserted"));
        }
        // else set the initial value of AmountInserted to 0
        else
        {
            AmountInserted = 0;
        }
        
        if (GetFormData(formData, "1") != null) {
            // call the insertCoin method with 1+AmountInserted as parameter
            ptm.insertCoin(1 + AmountInserted);
        }
        else if (GetFormData(formData, "2") != null) {
            // call the insertCoin method with 2+AmountInserted as parameter
            ptm.insertCoin(2 + AmountInserted);
        }
        else if (GetFormData(formData, "5") != null) {
            // call the insertCoin method with 5+AmountInserted as parameter
            ptm.insertCoin(5 + AmountInserted);
        }
        else if (GetFormData(formData, "10") != null) {
            // call the insertCoin method with 10+AmountInserted as parameter
            ptm.insertCoin(10 + AmountInserted);
        }
        else if (GetFormData(formData, "20") != null) {
            // call the insertCoin method with 20+AmountInserted as parameter
            ptm.insertCoin(20 + AmountInserted);
        }
        
        if (GetFormData(formData, "cancel") != null) {
            // reset the model to its initial state
            ViewBag.PaybackAmount = AmountInserted;
            ViewBag.Payback = true;
            ptm = new ParkingTicketMachine();
        }
        if (GetFormData(formData, "confirm") != null) {
            ptm.insertCoin(AmountInserted);
            // load the receipt view named "confirm" with the model as parameter
            return View("confirm", ptm);
        }
        // load the default view with the model as parameter
        return View(ptm);
    }
}