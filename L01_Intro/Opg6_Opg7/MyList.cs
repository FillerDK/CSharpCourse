namespace L01_Intro.Opg6_Opg7;

public class MyList
{
    List<int> numbers = [];
    
    public void AddNumber(int number)
    {
        numbers.Add(number);
    }
    
    public void PrintNumbers()
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}