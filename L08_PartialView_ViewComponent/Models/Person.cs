namespace L08_PartialView_ViewComponent.Models;

public class Person
{
    public string Fornavn { get; set; }
    public string Efternavn { get; set; }

    public Person(string fornavn, string efternavn)
    {
        Fornavn = fornavn;
        Efternavn = efternavn;
    }
}