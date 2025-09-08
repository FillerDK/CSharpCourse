namespace L04.Delegates.Opg4._6;

public class Person
{
    public int Age { get; set; }
    public int Weight { get; set; }
    public string Name { get; set; }

    public Person(int age, int weight, string name)
    {
        Age = age;
        Weight = weight;
        Name = name;
    }
    
    public override string ToString()
    {
        return string.Format(
            $"""
            Name: {Name}
            Age: {Age}
            Weight: {Weight}
            """);
    }

    public static void SortPeople(List<Person> people, PersonComparison comparison)
    {
        people.Sort((x, y) => comparison(x, y));
    }
}

public delegate int PersonComparison(Person x, Person y);