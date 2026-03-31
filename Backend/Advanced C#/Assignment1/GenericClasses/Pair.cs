namespace Assignment1.GenericClasses;

public class Pair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public void Deconstruct(out TKey key, out TValue value)
    {
        key = Key;
        value = Value;
    }

    public override string ToString()
    {
        return $"[{Key}: {Value}]";
    }
}
