using L03_Objektorientering.Opg3._7;

namespace L03_Objektorientering.Opg3._6;

public class Firma: IHarAdresse
{
    private Adresse adresse;

    public Firma() : this(new Adresse("DefaultVej", 1))
    {
    }
    
    public Firma(Adresse adresse)
    {
        this.adresse = adresse;
    }

    public Adresse Adresse
    {
        get { return adresse; }
        set { adresse = value; }
    }
}