using System.Collections;

public class MyList<T> : IEnumerable<T>
{
    T[]? list;
    int count;
    public int Count { get { return count; } }

    public MyList() { count = 0; list = null; }
    public MyList(T[]? list) { count = list.Length; this.list = list; }

    public IEnumerator<T> GetEnumerator()
    {
        return (IEnumerator<T>)list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }

    public T this[int index]
    {
        get => list[index];
        set => list[index] = value;
    }

    public void Add(T obj)
    {
        count++;
        T[] temp = new T[count];
        for (int i = 0; i < list.Length; i++) { temp[i] = list[i]; }
        temp[list.Length] = obj;
        list = temp;
    }

    public void Clear() { count = 0; list = null; }
}