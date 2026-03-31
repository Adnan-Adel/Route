namespace Assignment1.Constraints;

public struct Nullable<T> where T : struct
{
    private readonly bool hasValue;
    private readonly T value;

    public bool HasValue => hasValue;

    public T Value
    {
        get
        {
            if (!hasValue)
                throw new InvalidOperationException("No value");
            return value;
        }
    }

    public Nullable(T value)
    {
        hasValue = true;
        this.value = value;
    }

    public T GetValueOrDefault() => hasValue ? value : default;
    public T GetValueOrDefault(T defaultValue) => hasValue ? value : defaultValue;
}
