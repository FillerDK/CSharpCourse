namespace L04.Delegates.Opg4._6;

public class ByAgeSorter : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x == null || y == null) return 0;
        return x.Age.CompareTo(y.Age);
    }
}