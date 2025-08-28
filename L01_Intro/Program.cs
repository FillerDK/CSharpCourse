using L01_Intro.Opg3_Opg4;
using L01_Intro.Opg6_Opg7;

// Opg 4 (Test af opgave 3 og 4, person-klasse + ToString())
Console.WriteLine("Opg4:");
var person = new Person("martin");
Console.WriteLine(person);
person.Navn = "Benny";
Console.WriteLine(person + "\n");

// Opg 5 (ClassLibrary med interface)
Console.WriteLine("Opg5:");
string input;
var dyr = new List<string>();
do
{
    Console.WriteLine("Hvilket dyr skal tilføjes?");
    input = Console.ReadLine().Trim();
    if (input != "exit" && input is { Length: > 0 })
    {
        dyr.Add(input);
    }
} while (input != "exit");
Console.WriteLine("");
foreach (var d in dyr)
{
    Console.WriteLine(d);
}

// Opg 6 (Liste med tal der kan printes)
Console.WriteLine("\nOpg6:");
var list = new MyList();
list.AddNumber(1);
list.AddNumber(10);
list.AddNumber(100);
list.PrintNumbers();

// Opg 7 (Liste med 10 tilfældige tal)
Console.WriteLine("\nOpg7:");
var list7 = new MyList();
var rand = new Random();
var bytes = new byte[5];
rand.NextBytes(bytes);
for (var i = 0; i < 10; i++)
{
    list7.AddNumber(rand.Next(1, 101));
}
list7.PrintNumbers();