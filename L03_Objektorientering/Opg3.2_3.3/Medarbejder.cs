using L03_Objektorientering.Opg3._4;
using L03_Objektorientering.Opg3._6;
using L03_Objektorientering.Opg3._7;

namespace L03_Objektorientering.Opg3._2_3._3;

public abstract class Medarbejder: IHarAdresse
{
    private CprNr cpr;
    private string medarbejdernummer;
    private string navn;
    private Adresse adresse;

    public Medarbejder(): this(new CprNr("000000", "0000000000"),
        "00000000", "Medarbejder", new Adresse("MedarbejderVej", 1))
    {
    }
    
    public Medarbejder(CprNr cpr, string medarbejdernr, string navn, Adresse adresse)
    {
        this.cpr = cpr;
        medarbejdernummer = medarbejdernr;
        this.navn = navn;
        this.adresse = adresse;
    }

    public CprNr Cpr
    {
        get { return cpr; }
    }

    public string Medarbejdernummer
    {
        get { return medarbejdernummer; }
    }

    public string Navn
    {
        get { return navn; }
        set { navn = value; }
    }
    
    public Adresse Adresse
    {
        get { return adresse; }
        set { adresse = value; }
    }

    private const int _timerPrUge = 37;

    public abstract double BeregnUgeLøn();

    public int TimerPrUge
    {
        get { return _timerPrUge; }
    }

    public override string ToString()
    {
        return string.Format($"""
                             Medarbejder ({medarbejdernummer}):
                                Navn: {Navn}
                                Adresse: {Adresse}
                             """);
    }
}