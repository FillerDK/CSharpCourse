namespace L02_Sprogkonstruktioner.Opg3_Fibonacci;

public class Fibonacci
{
    public static void Calc_fibonacci(int n)
    {
        int a = 0, b = 1;

        for (var i = 0; i < n; i++)
        {
            Console.Write(i == 0 ? $"{a}" : $", {a}");
            var temp = a + b;
            a = b;
            b = temp;
        }
    }

    public static int[] GetSequence(int n)
    {
        int a = 0, b = 1;
        var arr = new int[n];
    
        for (var i = 0; i < n; i++)
        {
            arr[i] = a;

            var temp = a + b;
            a = b;
            b = temp;
        }
    
        return arr;
    }
}