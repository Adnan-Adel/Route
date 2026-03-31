namespace Assignment1.GenericClasses;

public class Cache<TKey, TValue> where TKey : notnull
{
    private class CacheEntry
    {
        public TValue Value { get; set; }
        public DateTime ExpiresAt { get; set; }

        public CacheEntry(TValue value, TimeSpan? ttl)
        {
            Value = value;
            ExpiresAt = ttl.HasValue ? DateTime.Now.Add(ttl.Value) : DateTime.MaxValue;
        }

        public bool IsExpired => DateTime.Now > ExpiresAt;
    }

    private readonly Dictionary<TKey, CacheEntry> storage = new();
    private readonly object lockObj = new();

    public void Add(TKey key, TValue value, TimeSpan? ttl = null)
    {
        lock (lockObj)
        {
            storage[key] = new CacheEntry(value, ttl);
        }
    }

    public TValue? Get(TKey key)
    {
        lock (lockObj)
        {
            if (storage.TryGetValue(key, out var entry))
            {
                if (entry.IsExpired)
                {
                    storage.Remove(key);
                    return default;
                }
                return entry.Value;
            }
            return default;
        }
    }

    public bool TryGet(TKey key, out TValue? value)
    {
        lock (lockObj)
        {
            if (storage.TryGetValue(key, out var entry) && !entry.IsExpired)
            {
                value = entry.Value;
                return true;
            }
            value = default;
            return false;
        }
    }

    public bool Remove(TKey key)
    {
        lock (lockObj)
        {
            return storage.Remove(key);
        }
    }

    public bool Contains(TKey key)
    {
        lock (lockObj)
        {
            if (storage.TryGetValue(key, out var entry))
            {
                if (entry.IsExpired)
                {
                    storage.Remove(key);
                    return false;
                }
                return true;
            }
            return false;
        }
    }

    public void Clear()
    {
        lock (lockObj)
        {
            storage.Clear();
        }
    }

    public int RemoveExpired()
    {
        lock (lockObj)
        {
            var expired = storage.Where(kvp => kvp.Value.IsExpired)
                                 .Select(kvp => kvp.Key)
                                 .ToList();

            foreach (var key in expired)
            {
                storage.Remove(key);
            }

            return expired.Count;
        }
    }

    public int Count
    {
        get
        {
            lock (lockObj)
            {
                RemoveExpired();
                return storage.Count;
            }
        }
    }

    public TValue? this[TKey key]
    {
        get => Get(key);
        set => Add(key, value!);
    }
}
