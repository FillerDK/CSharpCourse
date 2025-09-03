namespace L03_Objektorientering.Opg3._7;

public class Adresse
{
    private string vejnavn;
    private int nummer;
    
    public Adresse(string vejnavn, int nummer)
    {
        this.vejnavn = vejnavn;
        this.nummer = nummer;
    }

    public string Vejnavn
    {
        get { return vejnavn; }
        set { vejnavn = value; }
    }
    
    public int Nummer
    {
        get { return nummer; }
        set { nummer = value; }
    }
}