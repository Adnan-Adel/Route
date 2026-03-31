namespace Assignment1.Utilities;

public static class GenericMethods
{
    // Q5: FindMax with IComparable constraint
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array cannot be empty");

        T max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i].CompareTo(max) > 0)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static T FindMax2<T>(params T[] values) where T : IComparable<T>
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("No values provided");

        T max = values[0];
        foreach (T value in values)
        {
            if (value.CompareTo(max) > 0)
                max = value;
        }
        return max;
    }
}
