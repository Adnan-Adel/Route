namespace Assignment1.GenericClasses;

public class SafeList<T>
{
    private List<T> items = new();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count)
                return default!;
            return items[index];
        }
        set
        {
            if (index >= 0 && index < items.Count)
                items[index] = value;
        }
    }

    public T GetOrDefault(int index)
    {
        return (index >= 0 && index < items.Count) ? items[index] : default!;
    }

    public T GetOrDefault(int index, T defaultValue)
    {
        return (index >= 0 && index < items.Count) ? items[index] : defaultValue;
    }

    public int Count => items.Count;

    public bool TryGet(int index, out T value)
    {
        if (index >= 0 && index < items.Count)
        {
            value = items[index];
            return true;
        }
        value = default!;
        return false;
    }
}
