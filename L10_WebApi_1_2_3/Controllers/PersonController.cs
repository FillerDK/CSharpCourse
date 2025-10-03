using L10_WebApi_1_2_3.Model;
using Microsoft.AspNetCore.Mvc;

namespace L10_WebApi_1_2_3.Controllers;

[ApiController]
[Route("api/person")]
public class PersonController : ControllerBase
{
    private static List<Person> personer =
    [
        new Person { Id = 1, Name = "Bob" },
        new Person { Id = 2, Name = "Sonny" }
    ];
    
    [HttpGet]
    public List<Person> getPersoner()
    {
        return personer;
    }

    [HttpGet("{id:int}")]
    public Person getPersonById(int id)
    {
        return personer.Find(p => p.Id == id);
    }

    [HttpPost]
    public ActionResult addPerson(Person person)
    {
        personer.Add(person);
        return CreatedAtAction(nameof(getPersonById), new { id = person.Id }, person);
    }
}