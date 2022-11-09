public class Stuck<T>
{
    private List<T> values = new List<T>();
    public int Count => values.Count;
    public void Push(T value)
    {
        if (value == null)
        {
            throw new Exception("Incorrect data input");
        }
        values.Add(value);

    }
    public T Pop()
    {
        var value = values.LastOrDefault();
        if (value == null)
        {
            throw new Exception("Incorrect data input");
        }
        values.RemoveAt(values.Count - 1 );
        return value;
    }
    public T Peek()
    {
        var value = values.LastOrDefault();
        if (value == null)
        {
            throw new Exception("Incorrect data input");
        }
        return value;
    }

    public void Clear()
    {
        values.Clear();
    }

    public void CopyTo()
    {
        T[] myarray = new T[values.Count];

        values.CopyTo(myarray);
    }
}