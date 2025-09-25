using L08_PartialView_ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace L08_PartialView_ViewComponent.Components;

public class VisEnPerson : ViewComponent
{
    public IViewComponentResult Invoke(Person p)
    {
        p = new Person(p.Efternavn, p.Fornavn);

        return View(p);
    }
}