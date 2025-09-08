namespace L04.Opg4._1._4._3._4._4;

public static class Exts
{
    // Opg4.1
    public static bool Lang(this string x, int n)
    {
        return x.Length > n;
    }
    
    // Opg4.3
    public static int Factorial(this int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
    
    // Opg4.4
    public static int Power(this int n, int p)
    {
        var result = 1;
        for (var i = 0; i < p; i++)
        {
            result *= n;
        }
        return result;
    }
}