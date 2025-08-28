namespace L01_Intro.Opg3_Opg4;

public class Person
{
    public string navn;
    
    public string Navn
    {
        get
        {
            return navn;
        }
        set
        {
            navn = value;
        }
    }
    
    public Person (string navn)
    {
        Navn = navn;
    }

    public override string ToString()
    {
        return $"Name is {Navn}";
    }
}