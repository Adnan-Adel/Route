namespace Assignment1.Constraints;

public class Cache<T> where T : class
{
    private T? cachedItem;
    private DateTime? lastAccess;

    public T? Get()
    {
        lastAccess = DateTime.Now;
        return cachedItem;
    }

    public void Set(T item)
    {
        cachedItem = item;
        lastAccess = DateTime.Now;
    }

    public void Clear()
    {
        cachedItem = null;
        lastAccess = null;
    }

    public bool IsSame(T other)
    {
        return ReferenceEquals(cachedItem, other);
    }

    public bool IsEmpty => cachedItem == null;
}
