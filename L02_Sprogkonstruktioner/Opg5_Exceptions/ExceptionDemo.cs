namespace L02_Sprogkonstruktioner.Opg5_Exceptions;

public class ExceptionDemo
{
    private static void MyMethodWithError(int num = 0)
    {
        if (num == 0) throw new Exception("Tallet er 0!");
    }

    public static void MyNormalMethod(int num = 0)
    {
        try
        {
            MyMethodWithError(num);
            Console.WriteLine("Ingen exception fanget!");
        }
        catch (Exception)
        {
            Console.WriteLine("Exception blev fanget!");
        }
        finally
        {
            Console.WriteLine("Denne kode kører altid!");
        }
    }
}