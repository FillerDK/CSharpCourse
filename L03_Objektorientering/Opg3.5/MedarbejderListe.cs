using L03_Objektorientering.Opg3._6;

namespace L03_Objektorientering.Opg3._5;

public class MedarbejderListe<TKey>
{
    private readonly Dictionary<TKey, IHarAdresse>
        _collection = new Dictionary<TKey, IHarAdresse>();

    public void AddElement(TKey k, IHarAdresse p)
    {
        if (_collection.ContainsKey(k))
            throw new Exception("Duplicate element");
        _collection[k] = p;
    }

    public IHarAdresse GetElement(TKey k)
    {
        return !_collection.ContainsKey(k) ? null : _collection[k];
    }

    public int Size()
    {
        return _collection.Count;
    }
}