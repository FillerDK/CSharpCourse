using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        public ActionResult Index()
        {
            // 8. Ekstra parameter i constructoren
            // create a new product object with instance name glass
            var glass = new Product("Wine glass", 160.50, "grandcru.jpg", "IKEA");
            ViewBag.Glass = glass;
            
            // 1. Bin and knife products
            var bin = new Product("Trash bin", 40.95, "bin_35l.jpg", "Føtex");
            ViewBag.Bin = bin;

            var knife = new Product("Knife", 11.5, "st_knife.jpg", "Kop & Kande");
            ViewBag.Knife = knife;
			
            return View();
        }

    }
}
