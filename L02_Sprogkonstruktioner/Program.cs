using L02_Sprogkonstruktioner.Opg3_Fibonacci;
using L02_Sprogkonstruktioner.Opg4_CalculateAge;
using L02_Sprogkonstruktioner.Opg5_Exceptions;

namespace L02_Sprogkonstruktioner;

internal abstract class Program
{
    private static void Main(string[] args)
    {
        // Opg3 test
        Console.WriteLine("Opg3 (Fibonacci):");
        var seq = Fibonacci.GetSequence(9);
        Console.WriteLine(string.Join(", ", seq));
        
        // Opg4 test
        Console.WriteLine("\nOpg4 (AgeCalculator):");
        AgeCalculator.CalculateAge(new DateTime(2002, 5, 7), out int age);
        Console.WriteLine($"Alder: {age}\n");
        
        // Opg5 test
        ExceptionDemo.MyNormalMethod();
    }
}