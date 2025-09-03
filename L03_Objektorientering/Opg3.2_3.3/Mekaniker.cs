using L03_Objektorientering.Opg3._4;
using L03_Objektorientering.Opg3._7;

namespace L03_Objektorientering.Opg3._2_3._3;

public class Mekaniker: Medarbejder
{
    private int svendeprøve;
    private int timeløn;

    public Mekaniker(): this(new CprNr("000000", "0000000000"),
        "00000000", "Mekaniker", new Adresse("MekanikerVej", 1), 0, 0)
    {
    }

    public Mekaniker(
        CprNr cpr, string medarbejdernr, string navn, Adresse adresse,
        int svendeprøve, int timeløn): base(cpr, medarbejdernr, navn, adresse)
    {
        this.svendeprøve = svendeprøve;
        this.timeløn = timeløn;
    }

    public int Svendeprøve
    {
        get { return svendeprøve; }
        set { svendeprøve = value; }
    }

    public int Timeløn
    {
        get { return timeløn; }
        set { timeløn = value; }
    }

    public override double BeregnUgeLøn()
    {
        return timeløn * TimerPrUge;
    }
}