// Opg5.1
List<int> ints = [4, 9, 10, 2, 15, 20, 12, 50];
// Finder alle lige ints
var res511 = ints.FindAll(i => i % 2 == 0);
Console.WriteLine("511:");
res511.ForEach(Console.WriteLine);
// Finder det sidste tal over 15
var res512 = ints.FindLast(i => i > 15);
Console.WriteLine($"\nres512: {res512}");
// Finder index på det sidste tal over 15
ints.FindLastIndex(i => i > 15);

Console.WriteLine("\nTryk på en vilkårlig tast for at komme videre til opgave 5.2...");
Console.ReadKey();

// Opg5.2
// Finder alle lige ints
var res521 = ints.Where(i => i % 2 == 0);
Console.WriteLine("\nres521:");
foreach (var i in  res521)
{
    Console.WriteLine(i);
}
// Finder alle ints med præcis 2 cifre
var res522 = ints.Where(i => i.ToString().Length == 2);
Console.WriteLine("\nres522:");
foreach (var i in res522)
{
    Console.WriteLine(i);
}
Console.WriteLine();
res522 = res522.OrderBy(i => i);
foreach (var i in res522)
{
    Console.WriteLine(i);
}

Console.WriteLine("\nTryk på en vilkårlig tast for at afslutte...");
Console.ReadKey();