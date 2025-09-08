using L04.Delegates.Opg4._5;
using L04.Delegates.Opg4._6;
using L04.Opg4._1._4._3._4._4;
using L04.Opg4._2;

namespace L04.Delegates;

class Program
{
    static void Main(string[] args)
    {
        // Opg4.1 (Extensions)
        Console.WriteLine("Opg4.1 (Extensions):");
        var kort = "Kort";
        var lang = "LangString";

        Console.WriteLine($"Lang test 1: {kort.Lang(5)}");
        Console.WriteLine($"Lang test 2: {lang.Lang(5)}");

        // Opg4.1.a (Delegates)
        Console.WriteLine("\nOpg4.1.a (Delegates):");
        Console.WriteLine("Add:");
        CalculateAndDisplay(2, 3, Add);
        Console.WriteLine("Multiply:");
        CalculateAndDisplay(2, 3, Multiply);

        void CalculateAndDisplay(int a, int b, Operation operation)
        {
            Console.WriteLine($"a = {a}, b = {b}");
            var result = operation(a, b);
            Console.WriteLine($"Resultat = {result}");
        }

        static int Add(int a, int b) => a + b;
        static int Multiply(int a, int b) => a * b;
        
        // Opg4.2 a (Delegates)
        Console.WriteLine("\nOpg4.2 a (Delegates):");
        PowerPlant pp = new PowerPlant();
        pp.SetWarning(WarningToConsole);
        Console.WriteLine("Heater op...");
        pp.HeatUp();
        
        // Opg4.2 b (Delegates)
        pp.SetWarning(AnotherWarning);
        Console.WriteLine("Heater op...");
        pp.HeatUp();
        
        // Opg4.3 (Extensions)
        Console.WriteLine("\nOpg4.3 (Extensions):");
        Console.WriteLine("Test");
        Console.WriteLine($"Factorial 4: {4.Factorial()}");
        
        // Opg4.4 (Extensions)
        Console.WriteLine("\nOpg4.4 (Extensions):");
        Console.WriteLine($"Power: {2.Power(4)}");
        
        // Opg4.5 (Delegates)
        Console.WriteLine("\nOpg4.5 (Delegates):");
        var game = new CardGame();
        //game.AddCard(Suit.Clubs, Number.Ace);

        var billedKort = game.filterCardGame(FilterByPictureCard);
        Console.WriteLine("Printer kort ud...");
        foreach (var card in billedKort)
        {
            Console.WriteLine(card.ToString());
        }
        
        // Opg4.6 (Comparer)
        Console.WriteLine("\nOpg4.6 (Comparer):");
        var people = new List<Person>
        {
            new Person(25, 70, "Anna"),
            new Person(32, 85, "Benny"),
            new Person(19, 60, "Carla"),
            new Person(41, 90, "Dennis"),
            new Person(28, 75, "Emma"),
            new Person(36, 95, "Frederik"),
            new Person(22, 68, "Grethe"),
            new Person(30, 80, "Henrik"),
            new Person(27, 65, "Ida"),
            new Person(34, 88, "Jakob")
        };

        Person.SortPeople(people, CompareByName);

        foreach (var p in people)
        {
            Console.WriteLine(p.ToString() + "\n");
        }
        
        // Afslut program
        Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
        Console.ReadKey();
    }

    // Opg4.2 a (Powerplant, delegates)
    static void WarningToConsole()
    {
        Console.WriteLine("Advarsel!");
    }

    // Opg4.2 b (Powerplant, delegates)
    static void AnotherWarning()
    {
        Console.WriteLine("Another warning!");
    }
    
    // Opg4.5 (Spillekort, delegates)
    private static bool FilterByClubs(Card card)
    {
        return card.Suit == Suit.Clubs;
    }

    private static bool FilterByPictureCard(Card card)
    {
        return card.Number is (Number.Jack or Number.Queen or Number.King);
    }

    private static bool FilterByNonPictureCard(Card card)
    {
        return card.Number is not (Number.Jack or Number.Queen or Number.King);
    }
    
    // Opg4.6 (IComparater, Delegates)
    public static int CompareByAge(Person x, Person y)
    {
        return x.Age.CompareTo(y.Age);
    }

    public static int CompareByWeight(Person x, Person y)
    {
        return x.Weight.CompareTo(y.Weight);
    }

    public static int CompareByName(Person x, Person y)
    {
        return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
    }
}

// Opg4.1.a (Powerplant, delegates)
internal delegate int Operation(int a, int b);

//Opg4.2 a (Powerplant, delegates)
public delegate void Warning();