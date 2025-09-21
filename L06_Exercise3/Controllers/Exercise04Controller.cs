using L06_Exercise3.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_Exercise3.Controllers;

public class Exercise04Controller : Controller
{
    public ActionResult Index()
    {
        var books = new List<Book>
        {
            new Book
            (
                "Clean Code",
                399.95m,
                "/images/cleancode.jpg",
                "Robert C. Martin",
                "Prentice Hall",
                2008,
                "9780132350884"
            ),
            new Book
            (
                "The Pragmatic Programmer",
                349.50m,
                "/images/pragprog.jpg",
                "Andrew Hunt, David Thomas",
                "Addison-Wesley",
                1999,
                "9780201616224"
            ),
            new Book
            (
                "Design Patterns: Elements of Reusable Object-Oriented Software",
                459.00m,
                "/images/designpatterns.jpg",
                "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                "Addison-Wesley",
                1994,
                "9780201633610"
            )
        };

        var cds = new List<MusicCD>();

        var thriller = new MusicCD
        (
            "Thriller",
            129.95m,
            "/images/thriller.jpg",
            "Michael Jackson",
            "Epic",
            1982
        );
        thriller.AddTrack("Wanna Be Startin' Somethin'");
        thriller.AddTrack("Baby Be Mine");
        thriller.AddTrack("The Girl Is Mine");
        thriller.AddTrack("Thriller");
        thriller.AddTrack("Beat It");
        thriller.AddTrack("Billie Jean");
        thriller.AddTrack("Human Nature");
        thriller.AddTrack("P.Y.T. (Pretty Young Thing)");
        thriller.AddTrack("The Lady in My Life");
        cds.Add(thriller);

        var backInBlack = new MusicCD
        (
            "Back in Black",
            119.95m,
            "/images/backinblack.jpg",
            "AC/DC",
            "Atlantic Records",
            1980
        );
        backInBlack.AddTrack("Hells Bells");
        backInBlack.AddTrack("Shoot to Thrill");
        backInBlack.AddTrack("What Do You Do for Money Honey");
        backInBlack.AddTrack("Given the Dog a Bone");
        backInBlack.AddTrack("Let Me Put My Love Into You");
        backInBlack.AddTrack("Back in Black");
        backInBlack.AddTrack("You Shook Me All Night Long");
        backInBlack.AddTrack("Have a Drink on Me");
        backInBlack.AddTrack("Shake a Leg");
        backInBlack.AddTrack("Rock and Roll Ain’t Noise Pollution");
        cds.Add(backInBlack);

        var rumours = new MusicCD
        (
            "Rumours",
            139.95m,
            "/images/rumours.jpg",
            "Fleetwood Mac",
            "Warner Bros.",
            1977
        );
        rumours.AddTrack("Second Hand News");
        rumours.AddTrack("Dreams");
        rumours.AddTrack("Never Going Back Again");
        rumours.AddTrack("Don’t Stop");
        rumours.AddTrack("Go Your Own Way");
        rumours.AddTrack("Songbird");
        rumours.AddTrack("The Chain");
        rumours.AddTrack("You Make Loving Fun");
        rumours.AddTrack("I Don’t Want to Know");
        rumours.AddTrack("Oh Daddy");
        rumours.AddTrack("Gold Dust Woman");
        cds.Add(rumours);

        var svm = new StoreViewModel
        {
            Books = books,
            MusicCDs = cds
        };

        return View("Exercise04", svm);
    }
}