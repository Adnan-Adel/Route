namespace Assignment1.Inheritance;

public class Repository<T>
{
    protected List<T> Items = new();

    public virtual void Add(T item)
    {
        Items.Add(item);
    }

    public int Count => Items.Count;
}

// Pattern 1: Generic child
public class CachedRepository<T> : Repository<T>
{
    private Dictionary<int, T> cache = new();

    public override void Add(T item)
    {
        base.Add(item);
        cache[item!.GetHashCode()] = item;
    }
}

// Pattern 2: Concrete type
public class StringRepository : Repository<string>
{
    public void AddUpperCase(string value)
    {
        Add(value.ToUpper());
    }
}

// Pattern 3: Add new type parameter
public class KeyedRepository<TKey, TEntity> : Repository<TEntity> where TKey : notnull
{
    private Dictionary<TKey, TEntity> lookup = new();

    public void AddWithKey(TKey key, TEntity entity)
    {
        base.Add(entity);
        lookup[key] = entity;
    }

    public TEntity? GetByKey(TKey key)
    {
        return lookup.TryGetValue(key, out var entity) ? entity : default;
    }
}
