using L03_Objektorientering.Opg3._4;
using L03_Objektorientering.Opg3._7;

namespace L03_Objektorientering.Opg3._2_3._3;

public class Værkfører: Mekaniker
{
    private int udnævnelsesÅr;
    private int ugentligTillæg;

    public Værkfører(): this(new CprNr("000000", "0000000000"),
        "00000000", "Værkfører", new Adresse("VærkførerVej", 1), 0, 0, 0, 0)
    {
    }
    
    public Værkfører(
        CprNr cpr, string medarbejdernr,
        string navn, Adresse adresse,
        int svendeprøveÅr, int timeløn,
        int udnævnelsesÅr, int tillæg):
        base(cpr, medarbejdernr, navn, adresse, svendeprøveÅr, timeløn)
    {
        this.udnævnelsesÅr = udnævnelsesÅr;
        ugentligTillæg = tillæg;
    }

    public int UdnævnelsesÅr
    {
        get { return udnævnelsesÅr; }
        set { udnævnelsesÅr =  value; }
    }

    public int UgentligTillæg
    {
        get { return ugentligTillæg; }
        set { ugentligTillæg = value; }
    }

    public double BeregnUgeLøn()
    {
        return base.BeregnUgeLøn() + ugentligTillæg;
    }
}