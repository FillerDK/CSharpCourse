namespace L05_LINQ_5._3_5._12.Extensions;

public static class ListExts
{
    public static void SetAcceptedP(this List<Person.Person> lst, Predicate<Person.Person> pred)
    {
        foreach (var p in lst.Where(p => pred(p)))
        {
            p.Accepted = true;
        }
    }

    public static void Reset(this List<Person.Person> lst)
    {
        foreach (var person in lst)
        {
            person.Accepted = false;
        }
    }
}