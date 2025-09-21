using L06_Exercise3.Models;
using Microsoft.AspNetCore.Mvc;

namespace L06_Exercise3.Controllers;

public class Exercise05Controller : Controller
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
        // Tiløjer til Tracks
        thriller.AddTrack("Wanna Be Startin' Somethin'");
        thriller.AddTrack("Baby Be Mine");
        thriller.AddTrack("The Girl Is Mine");
        thriller.AddTrack("Thriller");
        thriller.AddTrack("Beat It");
        thriller.AddTrack("Billie Jean");
        thriller.AddTrack("Human Nature");
        thriller.AddTrack("P.Y.T. (Pretty Young Thing)");
        thriller.AddTrack("The Lady in My Life");
        // Tilføjer til TrackList
        thriller.AddTrack(new Track ("Wanna Be Startin' Somethin'", "Michael Jackson", "6:03"));
        thriller.AddTrack(new Track ("Baby Be Mine", "Rod Temperton", "4:20"));
        thriller.AddTrack(new Track ("The Girl Is Mine", "Michael Jackson", "3:42"));
        thriller.AddTrack(new Track ("Thriller", "Rod Temperton", "5:57"));
        thriller.AddTrack(new Track ("Beat It", "Michael Jackson", "4:18"));
        thriller.AddTrack(new Track ("Billie Jean", "Michael Jackson", "4:54"));
        thriller.AddTrack(new Track ("Human Nature", "John Bettis, Steve Porcaro", "4:06"));
        thriller.AddTrack(new Track ("P.Y.T. (Pretty Young Thing)", "James Ingram, Quincy Jones", "3:59"));
        thriller.AddTrack(new Track ("The Lady in My Life", "Rod Temperton", "4:59"));

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
        // Tilføjer til Tracks
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
        // Tilføjer til TrackList
        backInBlack.AddTrack(new Track ("Hells Bells", "Angus Young, Malcolm Young, Brian Johnson", "5:12"));
        backInBlack.AddTrack(new Track ("Shoot to Thrill", "Angus Young, Malcolm Young, Brian Johnson", "5:17"));
        backInBlack.AddTrack(new Track ("What Do You Do for Money Honey", "Angus Young, Malcolm Young, Brian Johnson", "3:36"));
        backInBlack.AddTrack(new Track ("Given the Dog a Bone", "Angus Young, Malcolm Young, Brian Johnson", "3:31"));
        backInBlack.AddTrack(new Track ("Let Me Put My Love Into You", "Angus Young, Malcolm Young, Brian Johnson", "4:15"));
        backInBlack.AddTrack(new Track ("Back in Black", "Angus Young, Malcolm Young, Brian Johnson", "4:15"));
        backInBlack.AddTrack(new Track ("You Shook Me All Night Long", "Angus Young, Malcolm Young, Brian Johnson", "3:30"));
        backInBlack.AddTrack(new Track ("Have a Drink on Me", "Angus Young, Malcolm Young, Brian Johnson", "3:59"));
        backInBlack.AddTrack(new Track ("Shake a Leg", "Angus Young, Malcolm Young, Brian Johnson", "4:06" ));
        backInBlack.AddTrack(new Track ("Rock and Roll Ain’t Noise Pollution", "Angus Young, Malcolm Young, Brian Johnson", "4:15"));

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
        // Tilføjer til Tracks
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
        // Tilføjer til TrackList
        rumours.AddTrack(new Track ("Second Hand News", "Lindsey Buckingham", "2:43"));
        rumours.AddTrack(new Track ("Dreams", "Stevie Nicks", "4:17" ));
        rumours.AddTrack(new Track ("Never Going Back Again", "Lindsey Buckingham", "2:14"));
        rumours.AddTrack(new Track ("Don’t Stop", "Christine McVie", "3:11"));
        rumours.AddTrack(new Track ("Go Your Own Way", "Lindsey Buckingham", "3:38"));
        rumours.AddTrack(new Track ("Songbird", "Christine McVie", "3:20"));
        rumours.AddTrack(new Track ("The Chain", "Buckingham, Nicks, C. McVie, J. McVie, Fleetwood", "4:30"));
        rumours.AddTrack(new Track ("You Make Loving Fun", "Christine McVie", "3:36"));
        rumours.AddTrack(new Track ("I Don’t Want to Know", "Stevie Nicks", "3:11"));
        rumours.AddTrack(new Track ("Oh Daddy", "Christine McVie", "3:54"));
        rumours.AddTrack(new Track ("Gold Dust Woman", "Stevie Nicks", "4:51"));

        cds.Add(rumours);

        var svm = new StoreViewModel
        {
            Books = books,
            MusicCDs = cds
        };

        return View("Exercise05", svm);
    }
}