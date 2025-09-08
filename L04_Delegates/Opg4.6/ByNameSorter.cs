namespace L04.Delegates.Opg4._6;

public class ByNameSorter : IComparer<Person>
{
    public int Compare(Person? x, Person? y)
    {
        if (x == null || y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        
        return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
    }
}