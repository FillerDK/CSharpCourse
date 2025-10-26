namespace L11_EntityFramework.Model;

public class Bil
{
    public int BilID { get; set; }
    public string Name { get; set; }
    public int Weight { get; set; }

    public Bil()
    {
        
    }

    public Bil(string name, int weight)
    {
        Name = name;
        Weight = weight;
    }
}