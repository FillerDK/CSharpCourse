using Microsoft.AspNetCore.Mvc;

namespace L06_MVC1.Controllers;

public class SimpleCalculatorController : Controller
{
    [HttpGet]
    public ActionResult SimpleCalculator()
    {
        return View();
    }

    [HttpPost]
    public ActionResult SimpleCalculator(IFormCollection formCollection)
    {
        var number1 = Convert.ToInt32(formCollection["Number1"]);
        var number2 = Convert.ToInt32(formCollection["Number2"]);
        var operatorOption = formCollection["operator"].ToString();
        
        var result = 0.0;
        var error = false;
        
        switch (operatorOption)
        {
            case "+":
                result = number1 + number2;
                break;
            case "-":
                result = number1 - number2;
                break;
            case "*":
                result = number1 * number2;
                break;
            case "/":
                if (number1 == 0 || number2 == 0)
                {
                    error = true;
                }
                else
                {
                    result = number1 / number2;
                }
                break;
            default:
                result = 0;
                break;
        }

        ViewBag.Number1 = number1.ToString();
        ViewBag.Number2 = number2.ToString();
        ViewBag.Result = result;
        ViewBag.Error = error;
        
        return View();
    }
}