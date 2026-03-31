namespace Assignment1.GenericClasses;

public class Container<T>
{
    private T[] items;
    private int count;

    public Container(int capacity = 10)
    {
        items = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count >= items.Length)
        {
            Array.Resize(ref items, items.Length * 2);
        }
        items[count++] = item;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException();

        return items[index];
    }

    public int Count => count;
}
