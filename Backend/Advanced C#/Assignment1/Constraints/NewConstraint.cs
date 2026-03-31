namespace Assignment1.Constraints;

public class Factory<T> where T : new()
{
    public T Create()
    {
        return new T();
    }

    public List<T> CreateMany(int count)
    {
        List<T> list = new List<T>();
        for (int i = 0; i < count; i++)
        {
            list.Add(new T());
        }
        return list;
    }

    public T CreateAndInitialize(Action<T> initializer)
    {
        T instance = new T();
        initializer(instance);
        return instance;
    }
}

public class Product
{
    public string Name { get; set; } = "Unknown";
    public decimal Price { get; set; }

    public Product() { }
}
