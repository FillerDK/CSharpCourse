using L03_Objektorientering.Opg3._0;
using L03_Objektorientering.Opg3._2_3._3;
using L03_Objektorientering.Opg3._4;
using L03_Objektorientering.Opg3._5;
using L03_Objektorientering.Opg3._6;
using L03_Objektorientering.Opg3._7;

namespace L03_Objektorientering;

public class Program
{
    public static void Main()
    {
        // Opg3.0 (Shapes, nedarvning)
        Console.WriteLine("Opg3.0 (Shapes, nedarvning):");
        var shapes = new List<Shape>();
        shapes.Add(new Circle(3, 5, 10));
        shapes.Add(new Circle(6, 1, 7));
        shapes.Add(new Circle(2, 8, 10));
        shapes.Add(new Rectangle(3, 8, 4, 1));
        shapes.Add(new Rectangle(5, 1, 5, 12));
        shapes.Add(new Rectangle(6, 9, 6, 12));

        double totalArea = 0;
        foreach (var shape in shapes)
        {
            totalArea += shape.Area();
        }
        Console.WriteLine($"Total area: {totalArea}");
        
        // Opg3.2 (Værksted, nedarvning)
        Console.WriteLine("\nOpg3.2 (Værksted, nedarvning):");
        var mekaniker1 = new Mekaniker(new CprNr("131279", "1312793054"), "00A163B6", "Sonny", new Adresse("Skel Vej", 63), 1988, 210);
        var værkfører1 = new Værkfører(new CprNr("230985", "2309856258"), "00C624D2", "Oleksykov", new Adresse("Due Stræde", 12), 1979, 200, 2000, 400);
        var synsmand1  = new Synsmand(new CprNr("300270", "3002705214"), "00K940E2","Henning", new Adresse("Brille Gade", 2), 1990, 190, [3]);

        var mekaniker2 = new Mekaniker(new CprNr("123456", "1234567890"), "123098123", "Hans", new Adresse("vej", 2), 1990, 200);
        var mekaniker3 = new Mekaniker(new CprNr("123456", "1234567890"), "102938233", "Søren", new Adresse("Sumsum", 3), 1999, 210);
        
        Console.WriteLine($"""
                          Mekaniker:
                            Navn: {mekaniker1.Navn}
                            Adresse: {mekaniker1.Adresse}
                            Svendeprøve: {mekaniker1.Svendeprøve}
                            Timeløn: {mekaniker1.Timeløn}
                          """);
        Console.WriteLine($"""
                           Værkfører:
                             Navn: {værkfører1.Navn}
                             Adresse: {værkfører1.Adresse}
                             Svendeprøve: {værkfører1.Svendeprøve}
                             Timeløn: {værkfører1.Timeløn}
                             Udnævnelses år: {værkfører1.UdnævnelsesÅr}
                             Ugentlig tillæg: {værkfører1.UgentligTillæg}
                           """);
        Console.WriteLine($"""
                           Synsmand:
                             Navn: {synsmand1.Navn}
                             Adresse: {synsmand1.Adresse}
                             Svendeprøve: {synsmand1.Svendeprøve}
                             Timeløn: {synsmand1.Timeløn}
                             Antal syn: {synsmand1.UgentligeSyn[0]}
                           """);
        
        // Opg3.3 (Værksted, polymorfi)
        Console.WriteLine("\nOpg3.3 (Værksted, polymorfi):");
        Console.WriteLine($"Mekaniker: {mekaniker1.BeregnUgeLøn()}");
        Console.WriteLine($"Værkfører: {værkfører1.BeregnUgeLøn()}");
        Console.WriteLine($"Synsmand: {synsmand1.BeregnUgeLøn()}");
        
        // Opg3.4 (Værksted, Cpr + ToString())
        Console.WriteLine("\nOpg3.4 (Værksted, Cpr + ToString()):");
        Console.WriteLine(mekaniker1.ToString());
        Console.WriteLine(værkfører1.ToString());
        Console.WriteLine(synsmand1.ToString());
        
        // Opg3.5 (Værksted, MedarbejderListe (Genetik))
        Console.WriteLine("\nOpg3.5 (Værksted, Genetik):");
        var medarbejderCollection = new MedarbejderListe<string>();
        medarbejderCollection.AddElement(mekaniker1.Cpr.SequenceNumber, mekaniker1);
        medarbejderCollection.AddElement(værkfører1.Cpr.SequenceNumber, værkfører1);
        medarbejderCollection.AddElement(synsmand1.Cpr.SequenceNumber, synsmand1);
        Console.WriteLine(medarbejderCollection.Size());
        medarbejderCollection.AddElement(mekaniker2.Cpr.SequenceNumber, mekaniker2);
        //medarbejderCollection.AddElement(mekaniker3.Cpr.SequenceNumber, mekaniker3); // giver fejl da den har samme CprNr, som mekaniker2
        Console.WriteLine(medarbejderCollection.Size());
        
        Console.WriteLine(medarbejderCollection.GetElement(mekaniker2.Cpr.SequenceNumber).ToString());
        
        // Opg3.6 (Værksted, Firma (Interface))
        Console.WriteLine("\nOpg3.6 (Værksted, interface):");
        var firma1 = new Firma(new Adresse("FirmaVej", 1));
        var firma2 = new Firma(new Adresse("FirmaVej", 2));
        medarbejderCollection.AddElement(firma1.Adresse.Vejnavn + firma1.Adresse.Nummer, firma1);
        medarbejderCollection.AddElement(firma2.Adresse.Vejnavn + firma2.Adresse.Nummer, firma2);
        Console.WriteLine(medarbejderCollection.GetElement(firma1.Adresse.Vejnavn + firma1.Adresse.Nummer).Adresse.Vejnavn);
        
        // Opg3.7 (Værksted, adresse klasse)
        // Fordelen ved at anvende dette i MedarbejderListe???
        
        // Opg3.8
        Console.WriteLine("\nOpg3.8 (Time, struct):");
        Time t1 = new Time("08:30:00");
        Time t2 = t1;
        t2.Hour = t2.Hour + 2;

        Console.WriteLine(t1.ToString()); // 08:30:00
        Console.WriteLine(t2.ToString()); // 10:30:00
    }
}

// Opg3.8 (Struct)
struct Time
{
    private int _secondsSinceMidnight;
    private const int _maxSeconds = 86400;

    /** Format for 'tidspunkt'; "hh:mm:ss" */
    public Time(string tidspunkt)
    {
        int hour = Int32.Parse(tidspunkt.Substring(0, 2));
        int min = Int32.Parse(tidspunkt.Substring(3, 2));
        int sek = Int32.Parse(tidspunkt.Substring(6, 2));
        _secondsSinceMidnight = hour * 3600 + min * 60 + sek;
    }

    public Time(int timer, int minutter, int sekunder)
    {
        _secondsSinceMidnight = timer * 3600 + minutter * 60 + sekunder;
    }
    
    public int Hour
    {
        set
        {
            int rest = _secondsSinceMidnight % 3600;
            _secondsSinceMidnight = (value * 3600 + rest) % _maxSeconds;
        }
        
        get => _secondsSinceMidnight / 3600;
    }

    public int Min
    {
        set
        {
            int hours = Hour;
            int sek = Sek;
            _secondsSinceMidnight = (hours * 3600 + value * 60 + sek) % _maxSeconds;
        }
        
        get => (_secondsSinceMidnight % 3600) / 60;
    }

    public int Sek
    {
        set
        {
            int hours = Hour;
            int min = Min;
            _secondsSinceMidnight = (hours * 3600 + min * 60 + value) % _maxSeconds;
        }
        
        get => _secondsSinceMidnight % 60;
    }

    public override string ToString()
    {
        return $"{Hour:D2}:{Min:D2}:{Sek:D2}";
    }
}