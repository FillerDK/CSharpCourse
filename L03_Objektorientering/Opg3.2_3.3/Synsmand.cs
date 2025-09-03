using L03_Objektorientering.Opg3._4;
using L03_Objektorientering.Opg3._7;

namespace L03_Objektorientering.Opg3._2_3._3;

public class Synsmand: Mekaniker
{
    private int[] ugentligeSyn;

    public Synsmand(): this(new CprNr("000000", "0000000000"),
        "00000000", "Synsmand", new Adresse("SynsmandsVej", 1), 0, 0, [0])
    {
    }

    public Synsmand(CprNr cpr, string medarbejdernr, string navn, Adresse adresse, int svendeprøve,
        int timeløn, int[] syn): base(cpr, medarbejdernr, navn, adresse, svendeprøve, timeløn)
    {
        ugentligeSyn = syn;
    }

    public int[] UgentligeSyn
    {
        get { return ugentligeSyn; }
        set { ugentligeSyn = value; }
    }

    public override double BeregnUgeLøn()
    {
        return base.BeregnUgeLøn() + (ugentligeSyn.Last() * 290);
    }
}