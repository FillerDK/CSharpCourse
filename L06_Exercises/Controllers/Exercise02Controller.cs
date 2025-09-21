using L06_Exercises.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_Exercises.Controllers;

public class Exercise02Controller : Controller
{
    public ActionResult Index()
    {
        var persons = new List<Person>();
        
        var anna  = new Person("Anna", "Jensen", "Søndergade 12", "8000", "Aarhus");
        anna.AddPhone("28471539");
        anna.Birthday = new DateTime(1980, 03, 01);

        var benny = new Person("Benny", "Mikkelsen", "Nørrebrogade 45", "2200", "København N");
        benny.AddPhone("61349285");
        benny.AddPhone("73142795");
        benny.Birthday = new DateTime(2000, 05, 20);

        var carla = new Person("Carla", "Madsen", "Havnegade 7", "5000", "Odense");
        carla.AddPhone("75903841");
        carla.Birthday = new DateTime(1979, 01, 17);
        
        persons.Add(anna);
        persons.Add(benny);
        persons.Add(carla);
        
        return View("Exercise02", persons);
    }
}