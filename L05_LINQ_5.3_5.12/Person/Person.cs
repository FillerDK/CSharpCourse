namespace L05_LINQ_5._3_5._12.Person;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Weight { get; set; }
    public int Score { get; set; }
    public bool Accepted { get; set; }

    public Person(string data)
    {
        // Name, Age, Weight, Score
        var parts = data.Split(';');
        
        Name     = parts[0];
        Age      = int.Parse(parts[1]);
        Weight   = int.Parse(parts[2]);
        Score    = int.Parse(parts[3]);
        Accepted = false;
    }

    public override string ToString()
    {
        return string.Format(
            $"""
            Name:     {Name}
            Age:      {Age}
            Weight:   {Weight}
            Score:    {Score}
            Accepted: {Accepted}
            """);
    }

    public static List<Person> ReadCSVFile(string filename)
    {
        var list = new List<Person>();
        using var file = new StreamReader(filename);
        string line;
        while ((line = file.ReadLine()) != null)
        {
            var p = new Person(line);
            list.Add(p);
            // Console.WriteLine(p);
        }

        return list;
    }
}