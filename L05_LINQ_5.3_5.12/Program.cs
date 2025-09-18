using L05_LINQ_5._3_5._12.Extensions;
using L05_LINQ_5._3_5._12.Person;

// --------------- Opg5.3 using FindAll ----------------
Console.WriteLine("Opg5.3 using FindAll:");
List<Person> people1;
Exercise1(out people1);
// Finder alle personer med en score under 2
var res53 = people1.Where(i => i.Score < 2);
Console.WriteLine("Personer med score under 2:");
foreach (var p in res53)
{
    Console.WriteLine(p + "\n");
}
// Finder alle personer med en lige score
res53 = people1.FindAll(i => i.Score % 2 == 0);
Console.WriteLine("Personer med lige score:");
foreach (var p in res53)
{
    Console.WriteLine(p + "\n");
}
// Finder alle personer med lige score og weight større end 60
res53 = people1.FindAll(i => i.Score % 2 == 0 && i.Weight > 60);
Console.WriteLine("Personer med lige score og weight over 60:");
foreach (var p in res53)
{
    Console.WriteLine(p + "\n");
}
//Finder alle personer med vægt deleligt med 3
res53 = people1.FindAll(i => i.Weight % 3 == 0);
Console.WriteLine("\nPersoner med vægt delelig med 3:");
foreach (var p in res53)
{
    Console.WriteLine(p + "\n");
}

Console.WriteLine("\nTryk på en vilkårlig tast for at komme til opgave 5.4...");
Console.ReadKey();

// --------------- Opg5.4 using FindIndex ---------------
Console.WriteLine("\nOpg5.4 using FindIndex:");
// Finder index på den første person med en score på 3
var res541 = people1.FindIndex(i => i.Score == 3);
Console.WriteLine(res541);
// Finder index på den første person under 10 år, som har en score på 3
var res542 = people1.FindIndex(i => i is { Age: < 10, Score: 3 });
Console.WriteLine(res542);
// Finder hvor mange personer der er under 10 år og har en score på 3
var res543 = people1.FindAll(i => i is { Age: < 10, Score: 3 }).Count;
Console.WriteLine(res543);
// Finder index på første person under 8 år med en score på 3
var res544 = people1.FindIndex(i => i is { Age: < 8, Score: 3 });
Console.WriteLine(res544);

Console.WriteLine("\nTryk på en vilkårlig tast for at komme til opgave 5.6...");
Console.ReadKey();

// ---------- Opg5.6 predicates og extension methods ----------
Console.WriteLine("\nOpg5.6 predicates og extension methods:");
// Test af extension metode
Console.WriteLine("Før:");
var preRes56 = people1.Where(p => p.Accepted);
foreach (var p in preRes56)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine();
}

people1.SetAcceptedP(p => p.Score >= 6 && p.Age <= 40);
Console.WriteLine("\nEfter:");
var postRes56 = people1.Where(p => p.Accepted);
foreach (var p in postRes56)
{
    Console.WriteLine(p.ToString());
    Console.WriteLine();
}

Console.WriteLine("\nTryk på en vilkårlig tast for at komme til opgave 5.7...");
Console.ReadKey();

// --------------- Opg5.7 LINQ ---------------
Console.WriteLine("\nOpg5.7 LINQ");
// Liste sorteret efter Score og Age
var res57 = people1
    .Where(p => p == p)
    .OrderBy(p => p.Score)
    .ThenBy(p => p.Age)
    .Select(p => (p.Score, p.Age));
foreach (var p in res57)
{
    Console.WriteLine(p);
}

Console.WriteLine("\nTryk på en vilkårlig tast for at komme til opgave 5.8...");
Console.ReadKey();

// --------------- Opg5.8 LINQ ---------------
Console.WriteLine("\nOpg5.8 LINQ:");
int[] numbers = [34, 8, 56, 31, 79, 150, 88, 7, 200, 47, 88, 20];
// 1. Returnerer alle two-digit integers i ascending order
Console.WriteLine("1. Two-digit integers ascending:");
var res581 = numbers
    .Where(i => DigitCount(i) == 2)
    .OrderBy(i => i);
foreach (var number in res581)
{
    Console.Write($"{number} ");
}
// 2. Returnerer alle two-digit integers i descending order
Console.WriteLine("\n2. Two-digit integers descending:");
var res582 = res581.OrderByDescending(i => i);
foreach (var number in res582)
{
    Console.Write($"{number} ");
}
// 3. Alle two-digit integers i ascending order, som strings
Console.WriteLine("\n3. Two-digit integers ascending, som strings:");
var res583 = res581
    .Select(n => n.ToString())
    .ToArray();
foreach (var number in res581)
{
    Console.Write($"{number} ");
}
// 4. Delopgave 2, som strings og med 'even'/'uneven'
Console.WriteLine("\n4. Two-digit integers descending, som string med 'even'/'uneven':");
var res584 = res582
    .Select(n => n.ToString() + (n % 2 == 0 ? " even" : " uneven"))
    .ToArray();
foreach (var number in res584)
{
    Console.Write($"{number} ");
}

Console.WriteLine("\n\nTryk på en vilkårlig tast for at komme til opgave 5.9...");
Console.ReadKey();

// --------------- Opg5.9 ---------------
Console.WriteLine("\nOpg5.9:");
people1.Reset();
var res59 = people1.Where(n => n.Accepted);
foreach (var p in res59)
{
    Console.WriteLine(p.ToString());
}

Console.WriteLine("\nTryk på en vilkårlig tast for at komme til opgave 5.10...");
Console.ReadKey();

// --------------- Opg5.10 ---------------
Console.WriteLine("Opg5.10:");
List<int> nums100 = [];
var rand = new Random();
for (var i = 1; i <= 100; i++)
{
    nums100.Add(rand.Next(1, 101));
}
// a) Find antal ulige tal
var res510a = nums100.Count(i => i % 2 == 1);
Console.WriteLine("a) " + res510a);
// b) Find antal unikke tal
var res510b = nums100.Distinct().Count();
Console.WriteLine("b) " + res510b);
// c) Find 3 første ulige tal
var res510c = nums100
    .Distinct()
    .Where(i => i % 2 == 1)
    .Take(3)
    .ToArray();
Console.Write("c) ");
foreach (var num in res510c)
{
    Console.Write($"{num} ");
}
// d) Find alle unikke ulige tal
Console.Write("\nd) ");
var res510d = nums100
    .Distinct()
    .Where(i => i % 2 == 1);
foreach (var num in res510d)
{
    Console.Write($"{num} ");
}

Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
Console.ReadKey();

return;

// --------------- Helper methods ---------------

void Exercise1(out List<Person> people1)
{
    try
    {
        people1 = Person.ReadCSVFile(
            @"C:\Users\phili\Desktop\Datamatiker\4. semester\CS_NET\CSharpCourse\L05_LINQ_5.3_5.12\CSV_Filer\data1.csv");
    }
    catch (Exception ex)
    {
        Console.WriteLine("EXCEPTION: " + ex.Message);
        Console.WriteLine("You should probably set the filename to the " +
                          "Person.ReadCSVFile method to something on your disk!");
        people1 = null;
    }
}

int DigitCount(int n) => n == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(n)) + 1);