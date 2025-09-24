using System.Text.Json;
using L07_HTML_helpers.Models.Exercise01;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace L07_HTML_helpers.Controllers;

public class Exercise01Controller : Controller
{
    private List<SelectListItem> countryList = new();

    [HttpGet]
    public ActionResult Index(string Countries)
    {
        var stored = HttpContext.Session.GetString("countryList");
        
        if (stored == null)
        {
            countryList.Add(new SelectListItem("Denmark", "DK"));
            countryList.Add(new SelectListItem("France", "FR"));
            countryList.Add(new SelectListItem("Japan", "JP"));
            countryList.Add(new SelectListItem("New Zealand", "NZ"));

            var dtos = countryList.Select(c => new CountryDto
            {
                Text = c.Text,
                Value = c.Value,
                Selected = c.Selected
            }).ToList();
            
            HttpContext.Session.SetString("countryList", JsonSerializer.Serialize(dtos));
        }
        else
        {
            var dtos = JsonSerializer.Deserialize<List<CountryDto>>(stored)!;
            countryList = dtos.Select(d => new SelectListItem(d.Text, d.Value, d.Selected))
                .ToList();
        }

        ViewBag.Countries = countryList;
        ViewBag.CountryCode = Countries;
        
        return View();
    }

    [HttpPost]
    public ActionResult Index(IFormCollection formData)
    {
        var stored = HttpContext.Session.GetString("countryList");

        if (stored != null)
        {
            var dtos = JsonSerializer.Deserialize<List<CountryDto>>(stored)!;
            countryList = dtos.Select(d => new SelectListItem(d.Text, d.Value, d.Selected)).ToList();
        }
        
        countryList.Add(new SelectListItem(formData["country"], formData["code"], true));

        ViewBag.Country = formData["country"];
        ViewBag.Code = formData["code"];

        ViewBag.Countries = countryList;

        var newDtos = countryList.Select(c => new CountryDto
        {
            Text = c.Text,
            Value = c.Value,
            Selected = c.Selected
        }).ToList();
        
        HttpContext.Session.SetString("countryList", JsonSerializer.Serialize(newDtos));
        
        return View();
    }
}