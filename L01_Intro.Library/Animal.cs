namespace L01_Intro.Library;

public class Animal : IAnimal
{
    public string Specie { get; set; }
    
    public Animal(string specie)
    {
        Specie = specie;
    }

    public bool IsDog()
    {
        if (Specie.ToLower() == "hund")
        {
            return true;
        }
        return false;
    }
    
    public override string ToString()
    {
        return $"Animal of species: {Specie}";
    }
}