namespace L04_Delegates_4._7;

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintPersonName(FormatPersonName formatter)
    {
        Console.WriteLine(formatter(FirstName, LastName));
    }

    public static List<Person> CreateListOfPeople() {
        return new List<Person>()
        {
            new Person() { FirstName = "Stephen", LastName = "King" },
            new Person() { FirstName = "George", LastName = "Martin" },
            new Person() { FirstName = "Ernest", LastName = "Hemingway" },
            new Person() { FirstName = "William", LastName = "Shakespeare" }
        };
    }
}

public delegate string FormatPersonName(string firstname, string lastname);