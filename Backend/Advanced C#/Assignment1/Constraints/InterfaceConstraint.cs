namespace Assignment1.Constraints;

public class Sorter<T> where T : IComparable<T>
{
    public void BubbleSort(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    public T FindMin(T[] array)
    {
        T min = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(min) < 0)
                min = item;
        }
        return min;
    }
}
